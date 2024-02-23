#!/usr/bin/env python

"""
upgrade-entries_v1-to-entries_v2.py

This script is used to upgrade all entries
on project Genesis from the v1 format to
the v2 format.
"""

import os
import sys

PARTITION = "## Notes\n"  # only modify the content after this line


def main(genesis_path: str) -> int:
    """
    The main function of the script.

    :param str genesis_path: The path of project Genesis vault
    :return int: The exit code of the script
    """

    entries_count = 0
    entries_template = os.path.join(genesis_path, "Meta", "Templates", "Entry.md")
    entries_path = os.path.join(genesis_path, "Entries")
    target_entries = [
        os.path.join(root, f)
        for root, _, files in os.walk(entries_path)
        for f in files
        if f.endswith("E.md")
    ]

    print("Genesis path:    ", genesis_path)
    print("Entries template:", entries_template)
    print("Detected entries:", len(target_entries))
    print()
    while True:
        print("[y] Proceed")
        print("[a] Abort operation")
        print("[l] List detected entries")
        print("[i] Show information")
        print()
        user_resp = input(" >>> ")
        print()
        if user_resp == "a":
            print("Operation aborted.")
            return 0

        elif user_resp == "l":
            print("Detected entries:")
            for entry in target_entries:
                print("-", entry)

            print()

        elif user_resp == "y":
            print()
            break

        elif user_resp == "i":
            print("Genesis path:    ", genesis_path)
            print("Entries template:", entries_template)
            print("Detected entries:", len(target_entries))
            print()

    print("Reading template...")
    with open(entries_template, "r") as f:
        template = f.read().partition(PARTITION)[2]

    print("Reading entries...\n")
    for entry_filepath in target_entries:
        print("-", entry_filepath)
        with open(entry_filepath, "r") as file_read:
            entry_content = file_read.read().partition(PARTITION)

        with open(entry_filepath, "w") as file_write:
            result = entry_content[0] + PARTITION + template
            file_write.write(result)

        entries_count += 1

    print(f"\n{entries_count} entries updated. Goodluck.")
    return 0


if __name__ == "__main__":
    sys.exit(main(sys.argv[1] if len(sys.argv) > 1 else os.getcwd()))
