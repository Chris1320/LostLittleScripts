"""
An automation script that uses ffmpeg to convert `.wav` files into `.flac`.

Both codecs are lossless, but FLAC uses lossless compression meaning that
we'll save storage space if WAV files are converted to FLAC.

WARNING: THIS SCRIPT REMOVES THE SOURCE (.WAV) FILE.
"""

import os
import sys

FROM_FORMAT: str = ".wav"
TO_FORMAT: str = ".flac"

def main() -> int:
    """
    The main function.

    :return int: The exit code.
    """

    for filename in os.listdir():
        if filename.lower().endswith(FROM_FORMAT):
            output_filename: str = filename[::-1].partition('.')[2][::-1] + TO_FORMAT
            if os.system(f"ffmpeg -i \"{filename}\" \"{output_filename}\"") != 0:
                return 1

            os.remove(filename)

    return 0


if __name__ == "__main__":
    sys.exit(main())
