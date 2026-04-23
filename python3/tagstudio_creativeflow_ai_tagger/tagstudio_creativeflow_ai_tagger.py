# /// script
# requires-python = ">=3.14"
# dependencies = [
#     "google-genai>=1.73.1",
#     "pillow>=12.2.0",
#     "tqdm>=4.67.3",
# ]
# ///

# pylint: disable=line-too-long

"""
TagStudio AI Tagger

Use Google Gemini to automatically tag assets in my TagStudio "Creative Flow" library.
"""

from __future__ import annotations

import argparse
import json
import mimetypes
import os
import sqlite3
import subprocess
import sys
import tempfile
import time

from dataclasses import asdict, dataclass, field
from pathlib import Path
from typing import Any, Final

from google import genai
from google.genai import errors, types
from PIL import Image
from PIL.ExifTags import TAGS as ExifTags
from tqdm import tqdm


@dataclass
class TagNode:
    id: int
    name: str
    is_category: bool
    children: list[TagNode] = field(  # pyright: ignore[reportUnknownVariableType]
        default_factory=list
    )

    @property
    def total_descendants(self) -> int:
        """Calculate the total number of descendant tags (children, grandchildren, etc.)."""

        return len(self.children) + sum(c.total_descendants for c in self.children)


@dataclass
class EntryInfo:
    """The info of an entry from TagStudio."""

    id: int
    filepath: Path
    filename: str
    filesuffix: str
    tags: list[TagNode] = field(  # pyright: ignore[reportUnknownVariableType]
        default_factory=list
    )


@dataclass
class ClassifierResponse:
    """The response from the classifier containing suggested tags and reasoning."""

    suggested_tags: list[int]  # List of suggested tag IDs
    confidence_score: float  # Confidence score for the suggestions (0.0 to 1.0)
    reasoning: str  # Brief explanation of why these tags were chosen


TAGSTUDIO_DB_FILENAME: Final[str] = ".TagStudio/ts_library.sqlite"
# Process only entries with any of the following tags
DEFAULT_TAGS_TO_PROCESS: Final[set[int]] = set(
    (1090,)  # ID of "Needs Metadata Update" tag
)
# Add the following tags to processed entries (if exists)
DEFAULT_TAGS_TO_ADD: Final[set[int]] = set((1130,))  # ID of "Tagged by AI" tag
# Remove the following tags from processed entries (if exists)
DEFAULT_TAGS_TO_REMOVE: Final[set[int]] = set(
    (1090,)  # ID of "Needs Metadata Update" tag
)
DEFAULT_ALLOW_CATEGORY_TAGS: Final[bool] = (
    False  # Whether to allow suggesting category tags (tags with is_category=True)
)

DEFAULT_GEMINI_MODEL: Final[str] = "gemini-3.1-flash-lite-preview"
DEFAULT_MAX_FILE_READ_SIZE: Final[int] = (
    5000  # Max number of characters to read from text files
)
DEFAULT_LIMIT: Final[int] = 0  # Limit the number of entries to process (0 for no limit)
DEFAULT_MIN_CONFIDENCE_SCORE: Final[float] = (
    0.80  # Minimum confidence score required to apply suggested tags
)
DEFAULT_CLASSIFIER_MAX_RETRIES: Final[int] = (
    3  # Max number of retries for classification request in case of failure
)
DEFAULT_CLASSIFIER_RETRY_DELAY: Final[int] = (
    5  # Delay in seconds between classification retries
)
DEFAULT_CLASSIFIER_DELAY: Final[float] = (
    4.0  # Delay in seconds between classification requests to avoid rate limits (set to 0 for no delay)
)
DEFAULT_FAIL_ON_MAX_RETRIES: Final[bool] = (
    False  # Whether to fail the entire process if max retries is exceeded for any entry
)

UNKNOWN_TAG = TagNode(id=-1, name="Unknown", is_category=False)

DOWNSCALE_IMAGE_MAX_DIMENSION: Final[int] = (
    768  # Max width or height for downscaled images
)
DOWNSCALE_VIDEO_MAX_HEIGHT: Final[int] = (
    480  # Max resolution height for downscaled videos (e.g., 480 for 480p)
)
DOWNSCALE_AUDIO_MAX_BITRATE: Final[int] = (
    128  # Max bitrate in kbps for downscaled audio (e.g., 128 for 128kbps)
)
FILE_UPLOAD_POLL_INTERVAL: Final[int] = (
    2  # Seconds to wait between checks for uploaded file status
)
FILE_UPLOAD_MAX_TIMEOUT: Final[int] = (
    60  # Seconds to wait for uploaded file to become ACTIVE before proceeding anyway
)

TEMP_DIR = tempfile.mkdtemp(prefix="tagstudio_ai_tagger_")
AI_SYSTEM_PROMPT: Final[
    str
] = """\
You are a professional Digital Asset Librarian. Your task is to analyze the uploaded media asset and provide precise metadata tagging based ONLY on the provided JSON taxonomy.

Core Rules:
- You may only suggest tags that exist in the provided JSON name fields. Do not invent new tags.
- Return your response strictly as a JSON object. No conversational text.
- For every tag you select, you must include its corresponding id from the taxonomy.
- If applicable, use the visual content of the image or video, audio features, and the provided technical properties (dimensions, suffix, etc.) to determine the tags.
- Do not return any ID where `is_category` is true. Only leaf tags should be suggested.
- An asset must have at least one tag from each of the following categories if applicable: Kind, Style, Theme, Utility. For example, an image could be tagged as "Overlay" (Kind), "Vintage" (Style), "Nature" (Theme), and "4K Resolution" (Utility).
  - An exception to the above rule is if the asset is a Document/Legal file, or a "Pack Tutorial" video/infographic/document. In that case, only tags from the "05 - Meta Tags" of the taxonomy should be applied, and tags from other categories (Kind, Style, Theme, Utility) should not be applied.
  - For example, a `License.pdf` file should be tagged with "Document" (Meta Tag) and should not be tagged with any Kind, Style, Theme, or Utility tags. Similarly, a "How to use.mp4" video should be tagged with "Pack Tutorial" (Meta Tag) and should not be tagged with any Kind, Style, Theme, or Utility tags.

Tagging Logic:
- 01 - Kind: Identify what the file actually is (e.g., is it an Overlay, a Background, or an Illustration?).
- 02 - Style: Identify the artistic "vibe" or design language (e.g., Vintage, Minimalist).
- 03 - Theme: Identify the primary subject matter or content of the asset.
- 04 - Utility: Use the technical properties provided to determine if it is "4K Resolution", "Raster Image", or used in "Post-Processing".

Taxonomy:
{TAXONOMY_JSON}

Sample Output Format:

```json
{
  "suggested_tags": [1002, 1004],
  "confidence_score": 0.95,
  "reasoning": "Brief explanation of why these tags were chosen."
}
```
"""


def get_entries_to_process(library_path: str, tags_to_process: set[int]) -> list[int]:
    """
    Get a list of entry IDs to process based on the specified tags.

    Args:
        library_path: The path to the TagStudio library.
        tags_to_process: A set of tag IDs to filter entries by. Only entries that have at least one of these tags will be included in the result.

    Returns:
        A list of entry IDs that have at least one of the specified tags.
    """

    conn = sqlite3.connect(Path(library_path) / TAGSTUDIO_DB_FILENAME)
    cursor = conn.cursor()
    query = f"""
        SELECT id FROM entries
        WHERE id IN (
            SELECT entry_id FROM tag_entries
            WHERE tag_id IN (
                {','.join('?' for _ in tags_to_process)}
            )
        )
    """

    cursor.execute(query, tuple(tags_to_process))
    return [row[0] for row in cursor.fetchall()]


def get_entry_info(library_path: str, entry_id: int) -> EntryInfo:
    """
    Get the information of an entry by its ID.

    Args:
        library_path: The path to the TagStudio library.
        entry_id: The ID of the entry to retrieve information for.

    Returns:
        An EntryInfo object containing the entry's information.
    """

    conn = sqlite3.connect(Path(library_path) / TAGSTUDIO_DB_FILENAME)
    cursor = conn.cursor()
    cursor.execute(
        "SELECT id, path, filename, suffix FROM entries WHERE id = ?", (entry_id,)
    )
    row = cursor.fetchone()
    if row:
        cursor.execute(
            """
            SELECT tags.id, tags.name, tags.is_category
            FROM tags
            JOIN tag_entries ON tags.id = tag_entries.tag_id
            WHERE tag_entries.entry_id = ?
            """,
            (entry_id,),
        )
        tags = [
            TagNode(id=t[0], name=t[1], is_category=bool(t[2]))
            for t in cursor.fetchall()
        ]

        return EntryInfo(
            id=row[0],
            filepath=Path(library_path) / row[1],
            filename=row[2],
            filesuffix=row[3],
            tags=tags,
        )

    raise ValueError(f"Entry with ID {entry_id} not found.")


def get_all_tags(library_path: str) -> list[TagNode]:
    """
    Get the hierarchy of the tags.

    Args:
        library_path: The path to the TagStudio library.

    Returns:
        A list of TagNode objects representing the root tags in the hierarchy.
    """

    conn = sqlite3.connect(Path(library_path) / TAGSTUDIO_DB_FILENAME)
    cursor = conn.cursor()

    # Get all tags
    cursor.execute("SELECT id, name, is_category FROM tags")
    tags = {
        row[0]: TagNode(id=row[0], name=row[1], is_category=bool(row[2]))
        for row in cursor.fetchall()
    }

    # Get all parent-child relationships
    cursor.execute("SELECT parent_id, child_id FROM tag_parents")

    # Build hierarchy
    child_ids: set[int] = set()
    for parent_id, child_id in cursor.fetchall():
        if parent_id in tags and child_id in tags:
            tags[parent_id].children.append(tags[child_id])
            child_ids.add(child_id)

    # Find root tags (tags with no parent)
    hierarchy = [tag for tag_id, tag in tags.items() if tag_id not in child_ids]

    return hierarchy


def get_all_tags_flat(library_path: str) -> dict[int, TagNode]:
    """
    Get a flat dictionary of all tags by their ID.

    Args:
        library_path: The path to the TagStudio library.

    Returns:
        A dictionary mapping tag IDs to TagNode objects.
    """

    conn = sqlite3.connect(Path(library_path) / TAGSTUDIO_DB_FILENAME)
    cursor = conn.cursor()

    cursor.execute("SELECT id, name, is_category FROM tags")
    return {
        row[0]: TagNode(id=row[0], name=row[1], is_category=bool(row[2]))
        for row in cursor.fetchall()
    }


def get_tag_by_id(library_path: str, tag_id: int) -> TagNode | None:
    """
    Get a tag by its ID.

    Args:
        library_path: The path to the TagStudio library.
        tag_id: The ID of the tag to retrieve.

    Returns:
        A TagNode object representing the tag, or None if not found.
    """

    conn = sqlite3.connect(Path(library_path) / TAGSTUDIO_DB_FILENAME)
    cursor = conn.cursor()
    cursor.execute("SELECT id, name, is_category FROM tags WHERE id = ?", (tag_id,))
    row = cursor.fetchone()
    if row:
        return TagNode(id=row[0], name=row[1], is_category=bool(row[2]))

    return None


def update_entry_tags(
    library_path: str,
    entry_id: int,
    tags_to_add: set[int],
    tags_to_remove: set[int],
    flat_tags_cache: dict[int, TagNode],
    allow_category_tags: bool = True,
) -> None:
    """
    Update the tags of an entry by adding and removing specified tags.

    Args:
        library_path: The path to the TagStudio library.
        entry_id: The ID of the entry to update.
        tags_to_add: A set of tag IDs to add to the entry.
        tags_to_remove: A set of tag IDs to remove from the entry.
        flat_tags_cache: A dictionary mapping tag IDs to TagNode objects for quick lookup.
        allow_category_tags: Whether to allow adding category tags (tags with `is_category=True`). If False, category tags in `tags_to_add` will be ignored.
    """

    conn = sqlite3.connect(Path(library_path) / TAGSTUDIO_DB_FILENAME)
    cursor = conn.cursor()

    # Add new tags
    for tag_id in tags_to_add:
        tag = flat_tags_cache.get(tag_id)
        if not tag:
            tqdm.write(f"[WARN] Tag ID {tag_id} not found in taxonomy. Skipping...")
            continue

        if not allow_category_tags and tag.is_category:
            tqdm.write(
                f"[WARN] Tag '{tag.name}' (ID {tag_id}) is a category tag and will not be added because `allow_category_tags` is False."
            )
            continue

        cursor.execute(
            "INSERT OR IGNORE INTO tag_entries (entry_id, tag_id) VALUES (?, ?)",
            (entry_id, tag_id),
        )

    # Remove specified tags
    for tag_id in tags_to_remove:
        cursor.execute(
            "DELETE FROM tag_entries WHERE entry_id = ? AND tag_id = ?",
            (entry_id, tag_id),
        )

    conn.commit()
    conn.close()


def downscale_image(
    image_path: Path, max_dimension: int = DOWNSCALE_IMAGE_MAX_DIMENSION
) -> Path:
    """
    Downscale an image to the specified maximum dimension while maintaining aspect ratio.

    Args:
        image_path: The path to the image file.
        max_dimension: The maximum width or height of the downscaled image.

    Returns:
        The filepath of the downscaled image.
    """

    output_path = Path(TEMP_DIR) / (image_path.stem + ".downscaled" + image_path.suffix)
    if not output_path.exists():
        # use pillow to downscale the image while explicitly preserving aspect ratio
        with Image.open(image_path) as img:
            width, height = img.size
            if width > max_dimension or height > max_dimension:
                if width > height:
                    new_width = max_dimension
                    new_height = int(max_dimension * (height / width))
                else:
                    new_height = max_dimension
                    new_width = int(max_dimension * (width / height))

                tqdm.write(
                    f"Downscaling image to {new_width}x{new_height} ({output_path})"
                )
                # Image.ANTIALIAS was removed in Pillow 10+, so we use Image.Resampling.LANCZOS
                img = img.resize(  # pyright: ignore[reportUnknownMemberType]
                    (new_width, new_height), Image.Resampling.LANCZOS
                )

            with open(output_path, "wb") as output:
                img.save(output, format=img.format or "JPEG")

    return output_path


def downscale_video(
    video_path: Path, max_height: int = DOWNSCALE_VIDEO_MAX_HEIGHT
) -> Path:
    """
    Downscale a video to the specified maximum height while maintaining aspect ratio.

    Args:
        video_path: The path to the video file.
        max_height: The maximum height of the downscaled video.

    Returns:
        The filepath of the downscaled video.
    """

    # use ffmpeg via subprocess to downscale the video while preserving aspect ratio
    output_path = Path(TEMP_DIR) / (video_path.stem + ".downscaled" + video_path.suffix)
    if not output_path.exists():
        command = [
            "ffmpeg",
            "-y",
            "-i",
            str(video_path),
            "-vf",
            f"scale=-2:{max_height}",
            "-c:a",
            "copy",  # copy audio without re-encoding
            str(output_path),
        ]
        tqdm.write(f"Downscaling video to max height {max_height} ({output_path})")
        subprocess.run(command, check=True)

    return output_path


def downscale_audio(
    audio_path: Path, max_bitrate: int = DOWNSCALE_AUDIO_MAX_BITRATE
) -> Path:
    """
    Downscale an audio file to the specified maximum bitrate while maintaining quality.

    Args:
        audio_path: The path to the audio file.
        max_bitrate: The maximum bitrate of the downscaled audio in kbps.

    Returns:
        The filepath of the downscaled audio.
    """

    output_path = Path(TEMP_DIR) / (audio_path.stem + ".downscaled" + ".mp3")
    if not output_path.exists():
        command = [
            "ffmpeg",
            "-y",
            "-i",
            str(audio_path),
            "-b:a",
            f"{max_bitrate}k",
            str(output_path),
        ]
        tqdm.write(
            f"Downscaling audio to max bitrate {max_bitrate} kbps ({output_path})"
        )
        subprocess.run(command, check=True)

    return output_path


def get_image_properties(image_path: Path) -> dict[str, Any]:
    """
    Get the properties of an image file, such as dimensions and file size.

    Args:
        image_path: The path to the image file.

    Returns:
        A dictionary containing the image properties.
    """

    # return all possible EXIF data as well as dimensions and file size, which can be useful for classification
    with Image.open(image_path) as img:
        width, height = img.size
        file_size_kb = image_path.stat().st_size / 1024
        exif_data = img.getexif()
        readable_exif = {
            ExifTags.get(tag_id, tag_id): value for tag_id, value in exif_data.items()
        }

    return {
        "width": width,
        "height": height,
        "file_size_kb": file_size_kb,
        "exif": readable_exif,
    }


def get_video_properties(video_path: Path) -> dict[str, Any] | None:
    """
    Get the properties of a video file, such as resolution, duration, and file size.

    Args:
        video_path: The path to the video file.

    Returns:
        A dictionary containing the video properties, or None if ffprobe fails to retrieve the information.
    """

    cmd: list[str] = [
        "ffprobe",
        "-v",
        "quiet",
        "-print_format",
        "json",
        "-show_format",
        "-show_streams",
        str(video_path),
    ]

    try:
        result = subprocess.run(cmd, capture_output=True, text=True, check=True)
        return json.loads(result.stdout)

    except Exception:  # pylint: disable=broad-exception-caught
        return None


def get_audio_properties(audio_path: Path) -> dict[str, Any] | None:
    """
    Get the properties of an audio file, such as duration, bitrate, and file size.

    Args:
        audio_path: The path to the audio file.

    Returns:
        A dictionary containing the audio properties, or None if ffprobe fails to retrieve the information.
    """

    # we use the same command anyway. Although we're keeping this for future adjustments.
    return get_video_properties(audio_path)


def parse_classifier_response(response_text: str) -> ClassifierResponse:
    """
    Parse the classifier response text into a ClassifierResponse object.

    Args:
        response_text: The raw text response from the classifier (expected to be JSON).

    Returns:
        A ClassifierResponse object containing the suggested tags and reasoning.
    """

    try:
        if response_text.startswith("```json"):
            response_text = response_text[len("```json") :].rstrip("```").strip()

        response_json = json.loads(response_text)
        return ClassifierResponse(
            suggested_tags=response_json.get("suggested_tags", []),
            confidence_score=response_json.get("confidence_score", 0.0),
            reasoning=response_json.get("reasoning", ""),
        )

    except json.JSONDecodeError as e:
        print(f"[ERROR] Failed to parse classifier response as JSON: {e}")
        raise ValueError("Invalid classifier response format") from e


def classify_entry(
    library_path: str,
    gemini_client: genai.Client,
    model: str,
    max_file_read_size: int,
    entry_info: EntryInfo,
    show_prompts: bool,
) -> ClassifierResponse:
    """
    Classify an entry and suggest tags based on its information and the provided taxonomy.

    Args:
        library_path: The path to the TagStudio library.
        gemini_client: The Google Gemini client.
        model: The Google Gemini model to use for classification.
        max_file_read_size: The maximum number of characters to read from text files for classification.
        entry_info: An EntryInfo object containing the entry's information.
        show_prompts: Whether to print the prompts used for classification to stdout for debugging purposes.

    Returns:
        A ClassifierResponse object containing the suggested tags and reasoning.
    """

    # Get the mimetype of the file.
    mime_type, _ = mimetypes.guess_type(entry_info.filepath)
    is_text = False

    if mime_type and (
        mime_type.startswith("text/")
        or mime_type in ["application/json", "application/xml", "application/csv"]
    ):
        is_text = True

    elif not mime_type:
        # Check if the file is text-like before assigning text/plain.
        try:
            with open(entry_info.filepath, "tr", encoding="utf-8") as f:
                f.read(1024)

            mime_type = "text/plain"
            is_text = True

        except (UnicodeDecodeError, OSError):
            mime_type = None

    contents: list[Any] = [
        # pylint: disable=consider-using-f-string
        """\
Asset Properties:
{0}
""".format(
            json.dumps(
                {
                    "filename": entry_info.filename,
                    "filesuffix": entry_info.filesuffix,
                    "tags": [t.name for t in entry_info.tags],
                },
                indent=4,
            )
        )
    ]

    tqdm.write(f"Determined MIME type:  {mime_type} (is_text={is_text})")
    entry_file: types.File | None = None
    downscaled_entry_info_filepath: Path | None = None
    if is_text:
        # Truncate text files and send them inline to avoid token limits
        try:
            with open(
                entry_info.filepath, "r", encoding="utf-8", errors="replace"
            ) as f:
                text_content = f.read(max_file_read_size)
                if len(text_content) == max_file_read_size:
                    text_content += "\n\n...[File truncated]..."

                contents.append(f"File Contents:\n{text_content}")

        except OSError as e:
            tqdm.write(f"[WARN] Failed to read text file. ({e})")

    elif mime_type:
        try:
            # Downscale images and videos before uploading to save tokens and improve
            # classification accuracy, while keeping the original file extension for
            # Gemini to recognize the file type.
            if mime_type.startswith("image/"):
                # Downscale image
                downscaled_entry_info_filepath = downscale_image(entry_info.filepath)
                img_props = get_image_properties(entry_info.filepath)
                if img_props:
                    contents.append(json.dumps(img_props, default=str))

            elif mime_type.startswith("video/"):
                # Downscale video
                downscaled_entry_info_filepath = downscale_video(entry_info.filepath)
                vid_props = get_video_properties(entry_info.filepath)
                if vid_props:
                    contents.append(json.dumps(vid_props, default=str))

            elif mime_type.startswith("audio/"):
                # Downscale audio
                downscaled_entry_info_filepath = downscale_audio(entry_info.filepath)
                aud_props = get_audio_properties(entry_info.filepath)
                if aud_props:
                    contents.append(json.dumps(aud_props, default=str))

            entry_file = gemini_client.files.upload(
                file=downscaled_entry_info_filepath or entry_info.filepath,
                config=types.UploadFileConfig(mime_type=mime_type),
            )
            contents.append(entry_file)

        except errors.ClientError as e:
            contents.append(
                f"Failed to upload file for analysis. MIME type: {mime_type}. Error: {e.message}"
            )
            tqdm.write(
                f"[WARN] Upload rejected by Gemini. Classifying from metadata only. ({e.message})"
            )

    else:
        contents.append(
            "Unknown binary file. Unable to analyze content. Classifying from metadata only."
        )
        tqdm.write("[WARN] Unknown binary file. Classifying from metadata only.")

    system_prompt = AI_SYSTEM_PROMPT.replace(
        r"{TAXONOMY_JSON}",
        json.dumps(
            [asdict(node) for node in get_all_tags(library_path)],
        ),
    )

    if show_prompts:
        tqdm.write("System Prompt:")
        tqdm.write(system_prompt)

        tqdm.write("Contents:")
        # Convert non-serializable objects to text descriptions
        text_contents: list[Any] = []
        for item in contents:
            if isinstance(item, (str, dict, list, int, float, bool, type(None))):
                text_contents.append(item)

            else:
                # Convert binary objects to descriptive text
                text_contents.append(f"[{type(item).__name__} object]")

        tqdm.write(json.dumps(text_contents, indent=4))

    if entry_file:
        tqdm.write("Waiting for uploaded file to be processed and become ACTIVE...")
        time_waited = 0
        while True:
            # check if file is ACTIVE
            if gemini_client.files.get(name=entry_file.name).state == "ACTIVE":
                tqdm.write("File is ACTIVE. Proceeding with classification.")
                break

            time.sleep(FILE_UPLOAD_POLL_INTERVAL)
            time_waited += FILE_UPLOAD_POLL_INTERVAL
            if time_waited >= FILE_UPLOAD_MAX_TIMEOUT:
                tqdm.write(
                    f"[WARN] Waited {time_waited} seconds for file to become ACTIVE. Proceeding with classification anyway."
                )
                break

    response = gemini_client.models.generate_content(  # pyright: ignore[reportUnknownMemberType]
        model=model,
        config=types.GenerateContentConfig(
            # We use `.replace` here to ensure that the JSON string is properly
            # escaped when inserted into the system prompt.
            system_instruction=system_prompt
        ),
        contents=contents,
    )

    if not response.text:
        raise ValueError("Empty response from classifier")

    # Clean up downscaled file if it was created
    if downscaled_entry_info_filepath and downscaled_entry_info_filepath.exists():
        try:
            downscaled_entry_info_filepath.unlink()

        except OSError as e:
            tqdm.write(f"[WARN] Failed to delete temporary downscaled file. ({e})")

    return parse_classifier_response(response.text)


def main(
    library_path: str,
    tags_to_process: set[int],
    tags_to_add: set[int],
    tags_to_remove: set[int],
    allow_category_tags: bool,
    min_confidence_score: float,
    limit: int,
    model: str,
    api_key: str,
    max_retries: int,
    retry_delay: int,
    delay: float,
    max_file_read_size: int,
    fail_on_max_retries: bool,
    filetype_include: set[str],
    filetype_exclude: set[str],
    show_prompts: bool,
) -> int:
    """
    Main function for the TagStudio AI Tagger.

    Args:
        library_path: The path to the TagStudio library.
        tags_to_process: A set of tag names to filter entries by. Only entries that have at least one of these tags will be processed.
        tags_to_add: A set of tag names to add to processed entries (if they exist in the taxonomy).
        tags_to_remove: A set of tag names to remove from processed entries (if they exist in the taxonomy).
        allow_category_tags: Whether to allow suggesting category tags (tags with `is_category=True`) instead of only leaf tags.
        min_confidence_score: Minimum confidence score required to apply suggested tags (0.0 to 1.0).
        limit: The maximum number of entries to process (0 for no limit).
        model: The Google Gemini model to use for classification.
        api_key: The Google API key for authentication.
        max_retries: The maximum number of retries for classification requests in case of failure.
        retry_delay: The delay in seconds between classification retries.
        delay: The delay in seconds between classification requests to avoid rate limits.
        max_file_read_size: The maximum number of characters to read from text files.
        fail_on_max_retries: Whether to fail the entire process if max retries is exceeded for any entry.
        filetype_include: A set of file suffixes to include (e.g., 'mp4', 'jpg'). Only entries with these suffixes will be processed. This overrides `filetype_exclude` if both are provided.
        filetype_exclude: A set of file suffixes to exclude (e.g., 'mp4', 'jpg'). Entries with these suffixes will be skipped.
        show_prompts: Whether to print the prompts used for classification to stdout for debugging purposes.

    Returns:
        An integer exit code (0 for success).
    """

    try:
        start_time = time.time()
        failed_entries: list[int] = []
        total_filetypes_processed: dict[str, int] = {}
        available_tags = get_all_tags_flat(library_path)

        if min_confidence_score < 0.0 or min_confidence_score > 1.0:
            print(
                f"[ERROR] Invalid minimum confidence score: {min_confidence_score}. Must be between 0.0 and 1.0."
            )
            return 1

        print("TagStudio AI Tagger")
        print()
        print(f"Library Path:          {library_path}")
        print(
            # pylint: disable=consider-using-f-string
            "Tags to Process:       {0}".format(
                ", ".join(
                    map(
                        lambda t: f"'{available_tags.get(t, UNKNOWN_TAG).name}'",
                        tags_to_process,
                    )
                )
            )
        )
        print(
            # pylint: disable=consider-using-f-string
            "Tags to Add:           {0}".format(
                ", ".join(
                    map(
                        lambda t: f"'{available_tags.get(t, UNKNOWN_TAG).name}'",
                        tags_to_add,
                    )
                )
            )
        )
        print(
            # pylint: disable=consider-using-f-string
            "Tags to Remove:        {0}".format(
                ", ".join(
                    map(
                        lambda t: f"'{available_tags.get(t, UNKNOWN_TAG).name}'",
                        tags_to_remove,
                    )
                )
            )
        )
        print(f"Google Gemini Model:   {model}")
        print(f"Minimum Confidence:    {min_confidence_score}")
        print(f"Temp Directory:        {TEMP_DIR}")
        print()

        entries_to_process = get_entries_to_process(library_path, tags_to_process)
        if filetype_include:
            entries_to_process = [
                eid
                for eid in entries_to_process
                if get_entry_info(library_path, eid).filesuffix in filetype_include
            ]

        # Explicitly apply only if `filetype_include` is not provided to avoid conflicts. If both are provided, `filetype_include` takes precedence.
        if filetype_exclude and not filetype_include:
            entries_to_process = [
                eid
                for eid in entries_to_process
                if get_entry_info(library_path, eid).filesuffix not in filetype_exclude
            ]

        if limit > 0:
            entries_to_process = entries_to_process[:limit]

        print(f"Found {len(entries_to_process)} entries to process.")

        client = genai.Client(api_key=api_key)

        # print("Current Tag Hierarchy:")
        # print(json.dumps([asdict(node) for node in get_all_tags(library_path)], indent=4))
        print("Root tags:")
        for tag in sorted(get_all_tags(library_path), key=lambda t: t.name):
            print(f"  - {tag.name} (Total descendants: {tag.total_descendants})")

        print()
        print("=" * os.get_terminal_size().columns)

        processed_count = 0
        for entry_id in tqdm(
            entries_to_process, desc="Tagging assets", dynamic_ncols=True
        ):
            tqdm.write(
                f"Processing entry ID:   {entry_id} ({processed_count + 1}/{len(entries_to_process)})"
            )
            entry_info = get_entry_info(library_path, entry_id)
            tqdm.write(f"Filepath:              {entry_info.filepath}")
            tqdm.write(f"Filename:              {entry_info.filename}")
            tqdm.write(f"File Suffix:           {entry_info.filesuffix}")
            tqdm.write(
                f"Current Tags:          {', '.join([f"'{t.name}'" for t in entry_info.tags])}"
            )

            current_retry = 0
            response: ClassifierResponse | None = None
            while current_retry <= max_retries:
                try:
                    response = classify_entry(
                        library_path=library_path,
                        gemini_client=client,
                        model=model,
                        max_file_read_size=max_file_read_size,
                        entry_info=entry_info,
                        show_prompts=show_prompts,
                    )

                    if response.confidence_score < min_confidence_score:
                        tqdm.write(
                            f"[INFO] Confidence score {response.confidence_score} is below the minimum threshold of {min_confidence_score}. Retrying... (Attempt {current_retry + 1}/{max_retries})"
                        )
                        raise ValueError(
                            f"Low confidence score: {response.confidence_score}"
                        )

                    break  # Break out of the retry loop if successful

                except Exception as e:  # pylint: disable=broad-exception-caught
                    tqdm.write(f"[ERROR] Classification failed: {e}")
                    current_retry += 1

                    if current_retry > max_retries:
                        if fail_on_max_retries:
                            raise e

                        tqdm.write(
                            f"[ERROR] Max retries exceeded for entry ID {entry_id}. Skipping..."
                        )
                        failed_entries.append(entry_id)
                        continue  # Move on to the next entry

                    else:
                        tqdm.write(
                            f"[INFO] Retrying in {retry_delay} seconds... (Attempt {current_retry}/{max_retries})"
                        )
                        time.sleep(retry_delay)

            if response is None:
                # This should not happen, but just in case...
                # I know this script is starting to look like mom's spaghetti,
                # but hey, it's working!
                continue

            # Map suggested tag IDs to names for display
            suggested_tag_names: list[str] = []
            for tag_id in response.suggested_tags:
                tag = available_tags.get(tag_id)
                if tag:
                    suggested_tag_names.append(tag.name)

                else:
                    tqdm.write(
                        f"[WARN] Suggested tag ID {tag_id} not found in taxonomy."
                    )

            new_tags_to_add = set(response.suggested_tags) | tags_to_add

            new_tags_to_add_names: list[str] = []
            for tag_id in new_tags_to_add:
                tag = available_tags.get(tag_id)
                if tag:
                    new_tags_to_add_names.append(tag.name)

                else:
                    tqdm.write(f"[WARN] Tag to add ID {tag_id} not found in taxonomy.")

            tags_to_remove_names: list[str] = []
            for tag_id in tags_to_remove:
                tag = available_tags.get(tag_id)
                if tag:
                    tags_to_remove_names.append(tag.name)

                else:
                    tqdm.write(
                        f"[WARN] Tag to remove ID {tag_id} not found in taxonomy."
                    )

            tqdm.write("")
            tqdm.write(
                f"Suggested Tags:        {', '.join([f"'{name}'" for name in suggested_tag_names])}"
            )
            tqdm.write(f"Confidence Score:      {response.confidence_score}")
            tqdm.write(f"Reasoning:             {response.reasoning}")
            tqdm.write("")
            tqdm.write(
                f"Tags to Add:           {', '.join([f"'{name}'" for name in new_tags_to_add_names])}"
            )
            tqdm.write(
                f"Tags to Remove:        {', '.join([f"'{name}'" for name in tags_to_remove_names])}"
            )
            tqdm.write("")

            update_entry_tags(
                library_path=library_path,
                entry_id=entry_id,
                tags_to_add=new_tags_to_add,
                tags_to_remove=tags_to_remove,
                flat_tags_cache=available_tags,
                allow_category_tags=allow_category_tags,
            )

            if delay > 0:
                tqdm.write(f"Waiting for {delay} seconds to avoid rate limits...")
                time.sleep(delay)

            tqdm.write("=" * os.get_terminal_size().columns)
            total_filetypes_processed[entry_info.filesuffix] = (
                total_filetypes_processed.get(entry_info.filesuffix, 0) + 1
            )
            processed_count += 1

        if len(failed_entries) > 0:
            print()
            print(f"Failed to process {len(failed_entries)} entries:")
            print(", ".join(map(str, failed_entries)))

        end_time = time.time()
        print()
        print("Processing complete.")
        print(f"Total entries processed: {processed_count}")
        # elapsed time in HH:MM:SS format
        print(
            f"Processing time:         {time.strftime('%H:%M:%S', time.gmtime(end_time - start_time))}"
        )
        print(f"Failed entries:          {len(failed_entries)}")
        print("Filetypes processed:")
        for suffix, count in total_filetypes_processed.items():
            print(f"  .{suffix}: {count}")

        if len(failed_entries) > 0:
            print()
            print("Failed entry IDs:")
            for entry_id in failed_entries:
                print(f"  {entry_id}")

        return len(failed_entries)

    except KeyboardInterrupt:
        print("\nProcess interrupted by user. Exiting.")
        return 1

    finally:
        # Clean up any temporary downscaled files in the temp directory
        for temp_file in Path(TEMP_DIR).iterdir():
            if not temp_file.is_file():
                continue

            try:
                temp_file.unlink()

            except OSError as e:
                print(f"[WARN] Failed to delete temporary file {temp_file}: {e}")

        try:
            # Attempt to remove the temp directory if it's empty
            Path(TEMP_DIR).rmdir()

        except OSError:
            pass  # It's fine if the temp directory is not empty or cannot be removed


if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="TagStudio AI Tagger")
    parser.add_argument(
        "library_path", help="Path to the TagStudio library (directory)"
    )
    parser.add_argument(
        "--tags-to-process",
        nargs="+",
        default=DEFAULT_TAGS_TO_PROCESS,
        help="Process only entries with any of the following tags (default: %(default)s)",
    )
    parser.add_argument(
        "--tags-to-add",
        nargs="+",
        default=DEFAULT_TAGS_TO_ADD,
        help="Add the following tags to processed entries (default: %(default)s)",
    )
    parser.add_argument(
        "--tags-to-remove",
        nargs="+",
        default=DEFAULT_TAGS_TO_REMOVE,
        help="Remove the following tags from processed entries (default: %(default)s)",
    )
    parser.add_argument(
        "--limit",
        type=int,
        default=DEFAULT_LIMIT,
        help="Limit the number of entries to process (0 for no limit)",
    )
    parser.add_argument(
        "--model",
        default=DEFAULT_GEMINI_MODEL,
        help="The Google Gemini model to use for classification (default: %(default)s; use `gemini-2.5-flash-lite` for cheaper but less capable model)",
    )
    parser.add_argument(
        "--api-key",
        default=os.getenv("GEMINI_API_KEY"),
        help="Google API key (default: read from GEMINI_API_KEY environment variable)",
    )
    parser.add_argument(
        "--max-retries",
        type=int,
        default=DEFAULT_CLASSIFIER_MAX_RETRIES,
        help="Maximum number of retries for classification requests (default: %(default)s)",
    )
    parser.add_argument(
        "--retry-delay",
        type=int,
        default=DEFAULT_CLASSIFIER_RETRY_DELAY,
        help="Delay in seconds between classification retries (default: %(default)s)",
    )
    parser.add_argument(
        "--delay",
        type=float,
        default=DEFAULT_CLASSIFIER_DELAY,
        help="Delay in seconds between classification requests to avoid rate limits (default: %(default)s)",
    )
    parser.add_argument(
        "--max-file-read-size",
        type=int,
        default=DEFAULT_MAX_FILE_READ_SIZE,
        help="Maximum number of characters to read from text files for classification (default: %(default)s)",
    )
    parser.add_argument(
        "--fail-on-max-retries",
        action="store_true",
        default=DEFAULT_FAIL_ON_MAX_RETRIES,
        help="Whether to fail the entire process if max retries is exceeded for any entry (default: %(default)s)",
    )
    parser.add_argument(
        "--allow-category-tags",
        action="store_true",
        help="Allow suggesting category tags (tags with `is_category=True`)",
    )
    parser.add_argument(
        "--min-confidence-score",
        type=float,
        default=DEFAULT_MIN_CONFIDENCE_SCORE,
        help="Minimum confidence score required to apply suggested tags (default: %(default)s)",
    )
    parser.add_argument(
        "--filetype-include",
        nargs="+",
        default=[],
        help="Process only entries with the following file suffixes (e.g., 'mp4', 'jpg'). This overrides `--filetype-exclude` if both are provided",
    )
    parser.add_argument(
        "--filetype-exclude",
        nargs="+",
        default=[],
        help="Exclude entries with the following file suffixes (e.g., 'mp4', 'jpg')",
    )
    parser.add_argument(
        "--show-prompts",
        action="store_true",
        help="Print the prompts used for classification to stdout for debugging purposes",
    )
    args = parser.parse_args()
    sys.exit(
        main(
            library_path=args.library_path,
            tags_to_process=set(args.tags_to_process),
            tags_to_add=set(args.tags_to_add),
            tags_to_remove=set(args.tags_to_remove),
            allow_category_tags=args.allow_category_tags,
            min_confidence_score=args.min_confidence_score,
            limit=args.limit,
            model=args.model,
            api_key=args.api_key,
            max_retries=args.max_retries,
            retry_delay=args.retry_delay,
            delay=args.delay,
            max_file_read_size=args.max_file_read_size,
            fail_on_max_retries=args.fail_on_max_retries,
            filetype_include=set(args.filetype_include),
            filetype_exclude=set(args.filetype_exclude),
            show_prompts=args.show_prompts,
        )
    )
