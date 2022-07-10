#!/usr/bin/env python3

"""
media-verifier.py

Check for corruption in my home theater.

Requirements:

- ass
- prettytable
- Pillow
- PyPDF2

NOTE:
This script does not guarantee that it will detect all corrupted files.
Manual analysis is still required.
"""

import os
import sys
import json
import zipfile
import subprocess

import ass
import prettytable
from PIL import Image
from PyPDF2 import PdfFileReader

ERRED_LIST = "problematic-media.txt"
JSON_OUTPUT_PATH = "media-verifier-output.json"  # The output file.
# TIMEOUT = 3

# TODO: ETA
# TODO: Faster video verifier. (It's slow as hell)


def imageVerifier(image_path: str) -> dict[str, str]:
    """
    Check if the image is corrupted.

    :param image_path: The image path.

    :returns: The verification result.
    """

    try:
        with Image.open(image_path) as image:
            image.verify()

    except Exception as e:
        result = {"status": "corrupted", "message": str(e)}

    else:
        result = {"status": "ok"}

    return result


def videoVerifier(video_path: str) -> dict[str, str]:
    """
    Check if the video is corrupted.

    :param video_path: The path of the video file.

    :returns: The verification result.
    """

    # Original command: `ffmpeg -v error -i filename.mp4 -map 0:1 -f null - 2>error.log`
    # Grabbed from:
    # - https://stackoverflow.com/questions/34077302/quickly-check-the-integrity-of-video-files-inside-a-directory-with-ffmpeg
    # which references:
    # - https://superuser.com/questions/100288/how-can-i-check-the-integrity-of-a-video-file-avi-mpeg-mp4#comment1367300_100290

    ffmpeg_command = "\"{exe}\" -v error -i \"{filename}\" -f null -"
    # ffprobe_command = "ffprobe -show_entries stream=r_frame_rate,nb_read_frames,duration -select_streams v -count_frames -of compact=p=1:nk=1 -threads 3 -v 0 \"{filename}\""
    # ffprobe_result = subprocess.getstatusoutput(ffprobe_command.format(filename=video_path))
    # if ffprobe_result[0] != 0:
    #     raise Exception(ffprobe_result[1])

    # else:
    #     # TODO: Check if the video is not corrupted.

    ffmpeg_result = subprocess.getoutput(ffmpeg_command.format(exe="ffmpeg", filename=video_path.replace('"', '\'').replace("$", "\\$")))
    if ffmpeg_result == '':
        result = {"status": "ok"}

    else:
        result = {"status": "anomalous", "message": ffmpeg_result}

    return result


def audioVerifier(audio_path: str) -> dict[str, str]:
    """
    Check if the audio is not corrupted.

    :param audio_path: The path of the audio file.

    :returns: The verification result.
    """

    return videoVerifier(audio_path)  # We are using the same command anyway.


def txtVerifier(txt_path: str) -> dict[str, str]:
    """
    Check if the text file is not corrupted.

    :param txt_path: The path to the text file.

    :returns: The verification result.
    """

    try:
        with open(txt_path, 'r', encoding="utf-8") as f:
            data = f.read()

        if data == '':
            raise Exception("Empty file.")

    except Exception as e:
        result = {"status": "corrupted", "message": str(e)}

    else:
        result = {"status": "ok"}

    return result


def subVerifier(sub_path: str) -> dict[str, str]:
    """
    Check if the subtitle file is not corrupted.

    :param sub_path: The path to the subtitle file.

    :returns: The verification result.
    """

    try:
        with open(sub_path, 'r', encoding="utf-8_sig") as f:
            # data = ass.parse(f)  # Just try to parse the subtitle file.
            ass.parse(f)

        # data.info
        # total_events = len(data.events)
        # for event in range(total_events - 1):
        #     data.events[event].dump()

    except Exception as e:
        result = {"status": "corrupted", "message": str(e)}

    else:
        result = {"status": "ok"}

    return result


def bookVerifier(book_path: str) -> dict:
    """
    Check if the book is not corrupted.

    :param book_path: The path to the book file.

    :returns: The verification result.
    """

    book_ext = book_path[::-1].partition('.')[0][::-1].lower()

    if book_ext == "pdf":
        try:
            with open(book_path, 'rb') as f:
                # This returns the document information,
                # or raises an error if it is unable to parse the file.
                PdfFileReader(f).getDocumentInfo()

        except Exception as e:
            result = {"status": "corrupted", "message": str(e)}

        else:
            result = {"status": "ok"}

    elif book_ext == "cbz":
        try:
            zf = zipfile.ZipFile(book_path)
            zf.testzip()  # A CBZ file is basically a zip file.

        except Exception as e:
            result = {"status": "corrupted", "message": str(e)}

        else:
            result = {"status": "ok"}

    else:
        result = {"status": "error", "message": "Unsupported book format."}

    return result


def main() -> int:
    """
    The main function of the program.

    :retuns: The exit code.
    """

    try:
        scan_dir = os.path.abspath(sys.argv[1])

    except IndexError:
        scan_dir = os.getcwd()

    if not os.path.isdir(scan_dir):
        print("The path does not exist or is not a directory.")
        return 2

    image_types = {"jpg", "jpeg", "png", "gif"}
    video_types = {"mp4", "avi", "mkv", "mov", "webm"}
    audio_types = {"mp3", "wav", "flac"}
    txt_types = {"nfo", "srt", "lrc", "xml", "json", "ini", "opf"}  # srt is basically a text file.
    sub_types = {"ass"}  # subtitles
    book_types = {"pdf", "cbz"}

    data = {
        "scanned": {
            "images": {},
            "videos": {},
            "audio": {},
            "txt": {},
            "sub": {},
            "books": {}
        },
        "errors": {
            "images": {},
            "videos": {},
            "audio": {},
            "txt": {},
            "sub": {},
            "books": {}
        },
        "skipped": [],
        "statistics": [0, 0, 0, 0, 0, 0],
        "filetypes": {
            "scanned": [],
            "skipped": []
        }
    }
    to_scan = {
        "images": [],
        "videos": [],
        "audio": [],
        "txt": [],
        "sub": [],
        "books": []
    }

    print()
    print(f"STEP 1: Starting scan of files in `{scan_dir}`...")
    print()

    # ? STEP #1: Scan the directory tree first.
    for root_dir, subdirs, filenames in os.walk(scan_dir):
        for filename in filenames:
            if os.path.isdir(os.path.join(root_dir, filename)):
                continue

            file_ext = os.path.join(root_dir, filename)[::-1].partition('.')[0][::-1]
            full_filepath = os.path.join(root_dir, filename)
            if file_ext in image_types:
                to_scan["images"].append(full_filepath)
                data["statistics"][0] += 1
                print(f"Found image ({data['statistics'][0]}): {full_filepath}")
                if file_ext not in data["filetypes"]["scanned"]:
                    data["filetypes"]["scanned"].append(file_ext)

            elif file_ext in video_types:
                to_scan["videos"].append(full_filepath)
                data["statistics"][1] += 1
                print(f"Found video ({data['statistics'][1]}): {full_filepath}")
                if file_ext not in data["filetypes"]["scanned"]:
                    data["filetypes"]["scanned"].append(file_ext)

            elif file_ext in audio_types:
                to_scan["audio"].append(full_filepath)
                data["statistics"][2] += 1
                print(f"Found audio ({data['statistics'][2]}): {full_filepath}")
                if file_ext not in data["filetypes"]["scanned"]:
                    data["filetypes"]["scanned"].append(file_ext)

            elif file_ext in txt_types:
                to_scan["txt"].append(full_filepath)
                data["statistics"][3] += 1
                print(f"Found text ({data['statistics'][3]}): {full_filepath}")
                if file_ext not in data["filetypes"]["scanned"]:
                    data["filetypes"]["scanned"].append(file_ext)

            elif file_ext in sub_types:
                to_scan["sub"].append(full_filepath)
                data["statistics"][4] += 1
                print(f"Found subtitle ({data['statistics'][4]}): {full_filepath}")
                if file_ext not in data["filetypes"]["scanned"]:
                    data["filetypes"]["scanned"].append(file_ext)

            elif file_ext in book_types:
                to_scan["books"].append(full_filepath)
                data["statistics"][5] += 1
                print(f"Found book ({data['statistics'][5]}): {full_filepath}")
                if file_ext not in data["filetypes"]["scanned"]:
                    data["filetypes"]["scanned"].append(file_ext)

            else:
                data["skipped"].append(full_filepath)
                if file_ext not in data["filetypes"]["skipped"]:
                    data["filetypes"]["skipped"].append(file_ext)

    print()
    print("Scan done!")
    print()
    # print("Skipped filetypes:")
    # for filetype in data["filetypes"]["skipped"]:
    #     print(f" - {filetype}")

    # print()

    # ? STEP #2: Verify the images.
    print("STEP 2: Verifying images...")
    print()
    i = 0
    for image_path in to_scan["images"]:
        try:
            print(f"Verifying {i + 1} of {data['statistics'][0]}: {image_path}")
            data["scanned"]["images"][image_path] = imageVerifier(image_path)

        except Exception as e:
            data["errors"]["images"].append({"path": image_path, "error": str(e)})

        finally:
            i += 1

    # ? STEP #3: Verify the videos.
    # if FFMPEG_EXE is None:
    #     print("ERROR: ffmpeg not found in PATH")
    #     return 1

    print("STEP 3: Verifying videos...")
    print()
    i = 0
    for video_path in to_scan["videos"]:
        try:
            print(f"Verifying {i + 1} of {data['statistics'][1]}: {video_path}")
            data["scanned"]["videos"][video_path] = videoVerifier(video_path)

        except Exception as e:
            data["errors"]["videos"].append({"path": video_path, "error": str(e)})

        finally:
            i += 1

    # ? STEP #4: Verify the audio files.
    print("STEP 4: Verifying audio files...")
    print()
    i = 0
    for audio_path in to_scan["audio"]:
        try:
            print(f"Verifying {i + 1} of {data['statistics'][2]}: {audio_path}")
            data["scanned"]["audio"][audio_path] = audioVerifier(audio_path)

        except Exception as e:
            data["errors"]["audio"].append({"path": audio_path, "error": str(e)})

        finally:
            i += 1

    # ? STEP #5: Verify the text files.
    print("STEP 5: Verifying text files...")
    print()
    i = 0
    for txt_path in to_scan["txt"]:
        try:
            print(f"Verifying {i + 1} of {data['statistics'][3]}: {txt_path}")
            data["scanned"]["txt"][txt_path] = txtVerifier(txt_path)

        except Exception as e:
            data["errors"]["txt"].append({"path": txt_path, "error": str(e)})

        finally:
            i += 1

    # ? STEP #6: Verify the subtitle files.
    print("STEP 6: Verifying subtitle files...")
    print()
    i = 0
    for sub_path in to_scan["sub"]:
        try:
            print(f"Verifying {i + 1} of {data['statistics'][4]}: {sub_path}")
            data["scanned"]["sub"][sub_path] = subVerifier(sub_path)

        except Exception as e:
            data["errors"]["sub"].append({"path": sub_path, "error": str(e)})

        finally:
            i += 1

    # ? STEP #7: Verify books.
    print("STEP 7: Verifying books...")
    print()
    i = 0
    for book_path in to_scan["books"]:
        try:
            print(f"Verifying {i + 1} of {data['statistics'][5]}: {book_path}")
            data["scanned"]["books"][book_path] = bookVerifier(book_path)

        except Exception as e:
            data["errors"]["books"].append({"path": book_path, "error": str(e)})

        finally:
            i += 1

    print()
    print("Verification done!")
    print()
    print("Writing results to file...")
    with open(os.path.join(os.getenv("HOME"), "temp", JSON_OUTPUT_PATH), 'w') as f:
        json.dump(data, f, indent=4)

    print("Done!")
    print()
    print("Results:")
    print()
    print(f"Found images: {data['statistics'][0]}")
    print(f"Found videos: {data['statistics'][1]}")
    print(f"Found audio: {data['statistics'][2]}")
    print(f"Found texts: {data['statistics'][3]}")
    print(f"Found subtitles: {data['statistics'][4]}")
    print(f"Found books: {data['statistics'][5]}")
    print()
    print("Scanned filetypes:")
    for filetype in data["filetypes"]["scanned"]:
        print(f" - {filetype}")

    print()
    print(f"- Scanned images: {data['statistics'][0]} (actual: {len(data['scanned']['images'])})")
    print(f"- Scanned videos: {data['statistics'][1]} (actual: {len(data['scanned']['videos'])})")
    print(f"- Scanned audio: {data['statistics'][2]} (actual: {len(data['scanned']['audio'])})")
    print(f"- Scanned texts: {data['statistics'][3]} (actual: {len(data['scanned']['txt'])})")
    print(f"- Scanned subtitles: {data['statistics'][4]} (actual: {len(data['scanned']['sub'])})")
    print(f"- Scanned books: {data['statistics'][5]} (actual: {len(data['scanned']['books'])})")
    print(f"- Skipped files: {len(data['skipped'])}")
    print()
    print("Errors:")
    print(f"- Images: {len(data['errors']['images'])}")
    print(f"- Videos: {len(data['errors']['videos'])}")
    print(f"- Audio: {len(data['errors']['audio'])}")
    print(f"- Texts: {len(data['errors']['txt'])}")
    print(f"- Books: {len(data['errors']['books'])}")
    print(f"- Subtitles: {len(data['errors']['sub'])}")
    print()
    table = prettytable.prettytable.PrettyTable(['#', "Filename", "Error Message"])
    with open(os.path.join(os.getenv("HOME"), "temp", ERRED_LIST), 'a') as f:
        i = 0
        for filepath in data["scanned"]["images"]:
            if data["scanned"]["images"][filepath]["status"] != "ok":
                i += 1
                table.add_row([i, filepath[::-1].partition(os.sep)[0][::-1], data["scanned"]["images"][filepath]["message"]])
                # print(f"- {filepath[::-1].partition(os.sep)[0][::-1]}: {data['scanned']['images'][filepath]['message']}")
                f.write(f"{filepath}\n")

        for filepath in data["scanned"]["videos"]:
            if data["scanned"]["videos"][filepath]["status"] != "ok":
                i += 1
                table.add_row([i, filepath[::-1].partition(os.sep)[0][::-1], data["scanned"]["videos"][filepath]["message"]])
                # print(f"- {filepath[::-1].partition(os.sep)[0][::-1]}: {data['scanned']['videos'][filepath]['message']}")
                f.write(f"{filepath}\n")

        for filepath in data["scanned"]["audio"]:
            if data["scanned"]["audio"][filepath]["status"] != "ok":
                i += 1
                table.add_row([i, filepath[::-1].partition(os.sep)[0][::-1], data["scanned"]["audio"][filepath]["message"]])
                # print(f"- {filepath[::-1].partition(os.sep)[0][::-1]}: {data['scanned']['audio'][filepath]['message']}")
                f.write(f"{filepath}\n")

        for filepath in data["scanned"]["txt"]:
            if data["scanned"]["txt"][filepath]["status"] != "ok":
                i += 1
                table.add_row([i, filepath[::-1].partition(os.sep)[0][::-1], data["scanned"]["txt"][filepath]["message"]])
                # print(f"- {filepath[::-1].partition(os.sep)[0][::-1]}: {data['scanned']['txt'][filepath]['message']}")
                f.write(f"{filepath}\n")

        for filepath in data["scanned"]["sub"]:
            if data["scanned"]["sub"][filepath]["status"] != "ok":
                i += 1
                table.add_row([i, filepath[::-1].partition(os.sep)[0][::-1], data["scanned"]["sub"][filepath]["message"]])
                # print(f"- {filepath[::-1].partition(os.sep)[0][::-1]}: {data['scanned']['sub'][filepath]['message']}")
                f.write(f"{filepath}\n")

        for filepath in data["scanned"]["books"]:
            if data["scanned"]["books"][filepath]["status"] != "ok":
                i += 1
                table.add_row([i, filepath[::-1].partition(os.sep)[0][::-1], data["scanned"]["books"][filepath]["message"]])
                f.write(f"{filepath}\n")

    table.title = "Anomalous files"
    print(table)
    print()
    print("Done, exiting...")
    return 0


if __name__ == "__main__":
    sys.exit(main())
