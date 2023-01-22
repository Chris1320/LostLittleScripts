"""
This script scans the current working directory for files with extensions
ending in <included> and/or excludes files ending in <excluded>.

When the files match the criteria, the filename is added onto the data
dictionary and is saved to <output_file> file.
"""

import os
import sys
import json

from typing import Final
from typing import Optional


EXTENSION_SEPARATOR: Final[str] = '.'
HELP_MENU: Final[str] = """
    USAGE: {cmd} [--include|-i <ext>] [--exclude|-e <ext>] [--output|-o <filename>]

    -i    --include        Include files ending in list <ext>. (separated by commas `,`)
    -e    --exclude        Exclude files ending in list <ext>. (separated by commas `,`)
    -o    --output         Write the results to <filename>.

[i] You cannot use include and exclude commands at the same time.
""".format(
    cmd = sys.argv[0]
)


def main(included: Optional[list] = None, excluded: Optional[list] = None, output_file: Optional[str] = None):
    print("Scanning current path....")
    print(f"To scan: {', '.join(included) if included is not None else None}")
    print(f"To skip: {', '.join(excluded) if excluded is not None else None}")
    print()

    scanned_exts: list = []
    scanned_num: int = 0
    data: dict[str, list[str]] = {}  # The dictionary that will be written to the output file.

    for root_dir, _, filenames in os.walk(os.getcwd()):
        for filename in filenames:
            scanned_ext = os.path.join(root_dir, filename)[::-1].partition(EXTENSION_SEPARATOR)[0][::-1].lower()
            if included is not None:
                if scanned_ext in included:
                    scanned_exts.append(scanned_ext) if scanned_ext not in scanned_exts else None
                    scanned_num += 1
                    if scanned_ext not in data:
                        data[scanned_ext] = []

                    data[scanned_ext].append(filename[::-1].partition(EXTENSION_SEPARATOR)[2][::-1].lower())
                    print(os.path.join(root_dir, filename))

            elif excluded is not None:
                if scanned_ext not in excluded:
                    scanned_exts.append(scanned_ext) if scanned_ext not in scanned_exts else None
                    scanned_num += 1
                    if scanned_ext not in data:
                        data[scanned_ext] = []

                    data[scanned_ext].append(filename[::-1].partition(EXTENSION_SEPARATOR)[2][::-1].lower())
                    print(os.path.join(root_dir, filename))

            else:
                print(HELP_MENU)
                return 2

    print()
    print("Scanned file extensions:")
    for ext in scanned_exts:
        print("- ", ext)

    print()
    print(f"Successfully scanned {scanned_num} files.")

    if output_file is not None:
        with open(output_file, 'w') as f:
            json.dump(data, f)

        print(f"Data saved to `{output_file}`.")

    else:
        print("Data not saved to file because output file is not set.")

    return 0


if __name__ == "__main__":
    to_include: Optional[list] = None
    to_exclude: Optional[list] = None
    output_file: Optional[str] = None
    skip_next_arg: bool = False

    try:
        for idx, arg in enumerate(sys.argv):
            if idx == 0:
                continue

            elif skip_next_arg:
                skip_next_arg = False
                continue

            if arg == "--include" or arg == "-i":
                if to_exclude is None:
                    to_include = sys.argv[idx + 1].split(',')
                    skip_next_arg = True

            elif arg == "--exclude" or arg == "-e":
                if to_include is None:
                    to_exclude = sys.argv[idx + 1].split(',')
                    skip_next_arg = True

            elif arg == "--output" or arg == "-o":
                output_file = sys.argv[idx + 1]
                skip_next_arg = True

            else:
                print(HELP_MENU)
                sys.exit(1)

    except IndexError:
        print(HELP_MENU)
        sys.exit(1)

    sys.exit(main(to_include, to_exclude, output_file))
