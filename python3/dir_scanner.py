"""
This script scans the current working directory for files with extensions
ending in <included>.

When the files match the criteria, the filename is added onto the data
dictionary and is saved to `songs.json` file.
"""

import os
import sys
import json

def main():
    included = ("mp3", "wav", "aiff", "wma", "m4a", "mkv", "mp4", "3gp")

    print("Scanning current path....")

    scanned_exts = []
    scanned_num = 0
    data = {
        "filenames": []
    }

    for root_dir, subdirs, filenames in os.walk('.'):
        for filename in filenames:
            scanned_ext = os.path.join(root_dir, filename)[::-1].partition('.')[0][::-1].lower()
            if scanned_ext in included:
                if scanned_ext not in scanned_exts:
                    scanned_exts.append(scanned_ext)

                scanned_num += 1
                data["filenames"].append(filename[::-1].partition('.')[2][::-1].lower())
                print(os.path.join(root_dir, filename))

    print("Scanned file extensions:")
    for ext in scanned_exts:
        print("- ", ext)

    print(f"Successfully scanned {scanned_num} files.")

    with open("songs.json", 'w') as f:
        json.dump(data, f)

    return 0

if __name__ == "__main__":
    sys.exit(main())
