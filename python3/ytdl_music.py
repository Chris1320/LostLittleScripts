#!/usr/bin/env python3

"""
Download music from YouTube.

NOTE: Use only as last resort when it is not available/for sale on any other platforms.

I occasionally find music that is available only on YouTube but is not available on
other platforms where I can buy it. I am lazy so I made this small script.
"""

import sys
import subprocess
from typing import Final

NAME: Final[str] = "ytdl_music"
VERSION: Final[int] = 1
HELP_MENU: Final[str] = f"""USAGE:

Simple usage:
\t{sys.argv[0]} [YouTube URL]

You can mix options and URLS like this:
\t{sys.argv[0]} [OPTIONS] [YouTube URL] ...

If for some reason the script detects the URL as an option, add `--` to explicitly
tell the program that the next arguments are URLs:
\t{sys.argv[0]} [OPTIONS] -- [YouTube URL]

OPTIONS:

--quality <quality>        Set a custom value for `--audio-format`. Default is `best`.
--output <format>          Set a custom value for `--output`.
--debug                    Enable debug mode."""
DEFAULT_OUTPUT_FORMAT: Final[str] = "best"
DEFAULT_OUTPUT_FILENAME_TEMPLATE: Final[str] = "%(artist,uploader)s - %(track,title)s.%(ext)s"

DEBUG_MODE: bool = False

def main(
    urls: list[str],
    output_format: str = DEFAULT_OUTPUT_FORMAT,
    output_filename_template: str = DEFAULT_OUTPUT_FILENAME_TEMPLATE
) -> int:
    """
    The main function of the script.

    :param list[str] urls: A list of URLs to download the file from.
    :param str output_format: value for `--audio-format`.
    :param str output_filename_template: value for `--output`.
    :return int: The exit code.
    """

    print(f"{NAME} v{VERSION}\n")
    if len(urls) < 1:
        print(HELP_MENU)
        return 0

    errors = 0
    base_command: list[str] = [
        "yt-dlp",  # Use yt-dlp to download.
        "--embed-metadata",
        "--embed-thumbnail",  # Embed the YouTube video's thumbnail as cover art.
        "--write-subs",  # Write the subtites as possible lyrics.
        "--extract-audio",  # Download only the audio.
        "--audio-format", output_format,  # Get the best possible audio quality by default.
        "--convert-subs", "lrc",
        "--output", output_filename_template
    ]

    if DEBUG_MODE:
        base_command.append("--verbose")
        print(f"{urls=}\n{output_format=}\n{output_filename_template=}\n{base_command=}\n")

    for url in urls:
        print(f"\n[{NAME}] Downloading `{url}`...")
        dl_cmd = base_command + [url]
        if DEBUG_MODE:
            print(f"[{NAME}]", dl_cmd)

        code = subprocess.call(dl_cmd)
        if code != 0:
            errors += 1

    print(f"[{NAME}] There are {errors} failed downloads.")
    return errors


if __name__ == "__main__":
    args = sys.argv[1:]
    urls_to_download: list[str] = []
    NO_OPTIONS_LEFT = False
    SKIP_NEXT_ARG = False
    custom_quality = DEFAULT_OUTPUT_FORMAT
    custom_placeholder = DEFAULT_OUTPUT_FILENAME_TEMPLATE

    for idx, arg in enumerate(args):
        if SKIP_NEXT_ARG:
            SKIP_NEXT_ARG = False
            continue

        if NO_OPTIONS_LEFT:
            urls_to_download.append(arg)

        else:
            if arg == "--":
                NO_OPTIONS_LEFT = True

            elif arg == "--debug":
                DEBUG_MODE = True

            elif arg == "--quality":
                custom_quality = args[idx + 1]
                SKIP_NEXT_ARG = True

            elif arg == "--output":
                custom_placeholder = args[idx + 1]
                SKIP_NEXT_ARG = True

            else:
                urls_to_download.append(arg)

    sys.exit(
        main(
            urls=urls_to_download,
            output_format=custom_quality,
            output_filename_template=custom_placeholder
        )
    )
