#!/usr/bin/env python

"""
Recursively enumerate DLLS in a specified directory.

This is used to add DLLs (usually mods) to the
`WINEDLLOVERRIDES` envvar of Wine.

This script was initially used to fix my Lethal Company
installation since I have a lot of mods installed.
"""

import os
import platform
import subprocess
import sys


def main(dir_to_scan: str, args: list[str]) -> int:
    """
    The main function.
    """

    dll_list: list[str] = []
    for _, _, filenames in os.walk(dir_to_scan):
        for filename in filenames:
            if filename.endswith(".dll"):
                dll_list.append(filename)

    print(f"Found {len(dll_list)} DLLs!")
    print()
    print(f"Appending {len(args)} pre-determined DLLs...")
    print()
    for dll in args:
        dll_list.append(dll)

    print("=" * 20, "STEAM LAUNCH OPTIONS", "=" * 20)
    print()
    launch_options = f"WINEDLLOVERRIDES=\"{','.join(dll_list)}=n,b\" gamemoderun %command%"
    print(launch_options)
    print()
    if platform.system() == "Linux":
        try:
            subprocess.run(["wl-copy", launch_options], check=True)
            print("Launch options copied to clipboard!")

        except subprocess.CalledProcessError:
            print(
                "Cannot copy launch options to clipboard. Please manually copy the output above."
            )

    print()
    print("Now that you have the command, do the following steps:")
    print()
    print("1. Open Steam.")
    print("2. Go to Library and select the game you are modding.")
    print("3. Select `Manage > Properties`.")
    print('4. In the General tab, paste the command into the "Launch Options" textbox.')
    return 0


if __name__ == "__main__":
    sys.exit(main(sys.argv[1], sys.argv[2:]))
