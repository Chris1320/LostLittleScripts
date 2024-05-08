#!/usr/bin/env python3

"""
get-rimworld-mods.py

This script will generate a list of URLs for the Steam Workshop page of each
mod in the specified directory. If the directory name is not a valid Steam
Workshop ID, it will be listed as an unknown mod.
"""

import os
import sys
import argparse
import webbrowser
from typing import Optional

MODS_PATH = "E:\\GOG\\RimWorld\\Mods"
BASE_URL = "https://steamcommunity.com/sharedfiles/filedetails/?id={mod_id}"


def main(rimworld_mods_path: str, output_file: Optional[str] = None, open_browser: bool = False) -> int:
    if not os.path.isdir(rimworld_mods_path):
        print("[ERROR] Directory does not exist.")
        return 1

    if output_file is not None:
        if os.path.exists(output_file):
            print("[ERROR] Output file exists. Won't overwrite.")
            return 2

    dir_contents: list[str] = os.listdir(rimworld_mods_path)
    mods_steam_url: list[str] = []
    mods_unknown: list[str] = []

    for idx, mod_dir in enumerate(dir_contents):
        if os.path.isdir(os.path.join(rimworld_mods_path, mod_dir)):
            if mod_dir.isdigit():
                mod_steam_url = BASE_URL.format(mod_id=mod_dir)
                mods_steam_url.append(mod_steam_url)
                print(f"[{idx + 1}]", mod_steam_url)

            else:
                mods_unknown.append(mod_dir)
                print(f"[{idx + 1}]", mod_dir)

    print(f"{len(mods_steam_url) + len(mods_unknown)} mods detected.")
    if output_file is not None:
        with open(output_file, 'w') as f:
            for line in mods_steam_url:
                f.write(f"{line}\n")

            f.write("\nUnknown mods:\n")
            for line in mods_unknown:
                f.write(f"{line}\n")

        print(f"Output saved to {output_file}")

    if open_browser:
        print("Opening Steam links in default browser.")
        for link in mods_steam_url:
            webbrowser.open_new_tab(link)

    return 0


if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="Generate mod list and save to file")
    parser.add_argument("-m", "--mods", dest="rimworld_mods_path", default=MODS_PATH, help="The directory that contains the mods")
    parser.add_argument("-o", "--output", dest="output_file", help="The file where the output will be stored")
    parser.add_argument("-b", "--browser", action="store_true", dest="open_browser", help="Open the links in default browser")
    cli_args = parser.parse_args()
    sys.exit(main(cli_args.rimworld_mods_path, cli_args.output_file, cli_args.open_browser))
