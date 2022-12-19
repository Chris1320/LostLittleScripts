#!/usr/bin/env python3

"""
This script is tested on Windows 11 and Linux Mint 21
"""

import os
import sys
import shutil
import textwrap
import subprocess

from typing import Final
from typing import Optional


PROGRAM_NAME: Final[str] = "ADB Bloat Uninstaller"
PROGRAM_VERSION: Final[tuple[int, int, int]] = (0, 1, 0)


# START: User Interface Objects taken from ConfigHandler-python (https://github.com/Chris1320/ConfigHandler-python/blob/master/config_handler/_ui.py)
def clearScreen() -> None:
    os.system("cls" if os.name == "nt" else "clear")


def confirm(message: str = "Press enter to continue...") -> None:
    input(message)


class InputBox:
    """
    Show an input box to the user and return their input.
    """

    def __init__(
        self,
        title: str,
        description: Optional[str] = None,
        margin: int = 4,
        title_fill_char: str = ' ',
        clear_screen: bool = True,
        input_prompt: str = " >>> "
    ):
        """
        Initialize the InputBox() class.

        :param title: The title of the input box.
        :param description: The description of the input box. (default: None)
        :param margin: The margin of the description. (default: 4)
        :param title_fill_char: The character to fill the sides of the title with. (default: ' ')
        :param clear_screen: Whether to clear the screen before showing the dialog. (default: True)
        :param input_prompt: The prompt to show beside the user's input field. (default: " >>> ")
        """

        self.title = title
        self.description = description
        self.margin = margin
        self.title_fill_char = title_fill_char
        self.clear_screen = clear_screen
        self.input_prompt = input_prompt

    def __call__(self) -> str:
        """
        Show the dialog to the user and return their input.

        :returns: The input of the user.
        """

        if self.clear_screen:
            clearScreen()

        print(self.__buildDialog())
        return input(self.input_prompt)

    def __str__(self) -> str:
        """
        Get a string representation of the dialog.
        This will not clear the screen nor ask for the user's input.

        :returns: The string representation of the dialog.
        """

        return self.__buildDialog()

    def __buildDialog(self) -> str:
        """
        Build the dialog.

        :returns: The dialog.
        """

        # Center and add the title.
        result: str = f"\n{self.title.center(shutil.get_terminal_size().columns, self.title_fill_char)}\n\n"
        if self.description is not None:  # Center and add the description.
            for desc_line in self.description.split('\n'):
                for line in textwrap.wrap(
                    desc_line,
                    shutil.get_terminal_size().columns - (self.margin * 2)
                ):
                    result += f"{line.center(shutil.get_terminal_size().columns)}\n"

            result += '\n'

        return result


class Choices:
    """
    Show a menu of choices to the user and return the choice they make.
    """

    def __init__(
        self,
        list_of_choices: dict[str, str],
        title: str,
        description: Optional[str] = None,
        minimum_spaces: int = 1,
        margin: int = 4,
        title_fill_char: str = ' ',
        clear_screen: bool = True,
        case_sensitive: bool = False,
        input_prompt: str = " >>> "
    ):
        """
        Initialize the Choice() class.

        :param list_of_choices: A dictionary containing the ID and description of each choice.
        :param title: The title of the choice dialog.
        :param description: A description about the choice dialog. (default: None)
        :param minimum_spaces: The minimum number of spaces between the ID and description. (default: 1)
        :param margin: The margin of the description. (default: 4)
        :param title_fill_char: The character to fill the sides of the title with. (default: ' ')
        :param clear_screen: Whether to clear the screen before showing the dialog. (default: True)
        :param case_sensitive: Whether to ignore case when comparing the user's input to the IDs. (default: False)
        :param input_prompt: The prompt to show beside the user's input field. (default: " >>> ")
        """

        self.list_of_choices = list_of_choices

        self.title = title
        self.description = description
        self.minimum_spaces = minimum_spaces

        self.margin = margin
        self.title_fill_char = title_fill_char
        self.clear_screen = clear_screen
        self.case_sensitive = case_sensitive
        self.input_prompt = input_prompt

    def __call__(self, prompt_only: bool = False) -> str:
        """
        Show the dialog to the user and return the choice they make.

        :returns: The choice the user made.
        """

        while True:
            if self.clear_screen:
                clearScreen()

            if not prompt_only:
                print(self.__buildDialog())

            choice = input(self.input_prompt)  # Get the user's choice.
            if self.case_sensitive:
                if choice in self.list_of_choices.keys():
                    return choice

            else:
                if choice.lower() in [  # Convert the keys to lowercase ONLY IF the key is a string.
                    key.lower() if type(key) is str else key
                    for key in self.list_of_choices.keys()
                ]:
                    return choice

    def __str__(self) -> str:
        """
        Get a string representation of the dialog.
        This will not clear the screen nor ask for the user's input.

        :returns: The string representation of the dialog.
        """

        return self.__buildDialog()

    def __buildDialog(self) -> str:
        """
        Build the dialog.
        """

        # Center and add title.
        result: str = f"\n{self.title.center(shutil.get_terminal_size().columns, self.title_fill_char)}\n\n"

        if self.description is not None:  # Center and add description.
            for desc_line in self.description.split('\n'):
                for line in textwrap.wrap(
                    desc_line,
                    shutil.get_terminal_size().columns - (self.margin * 2)
                ):
                    result += f"{line.center(shutil.get_terminal_size().columns)}\n"

            result += '\n'

        result += self.getChoicesList()
        result += '\n'
        return result

    def getChoicesList(self) -> str:
        """
        Return a string containing the formatted choices list without the title and description.
        """

        result: str = ""

        # Get the longest key; to be used in formatting the choices.
        longest_id = max(
            (len(key) if key is not None else 0)
            for key in self.list_of_choices.keys()
        )

        # Format and add choices to result.
        for choice_id, choice_description in self.list_of_choices.items():
            spacer = ' ' * (self.minimum_spaces + (longest_id - len(str(choice_id))))
            result += f"[{choice_id}]{spacer}{choice_description}\n"

        return result
# END: User Interface Objects from ConfigHandler-python (https://github.com/Chris1320/ConfigHandler-python/blob/master/config_handler/_ui.py)


class ADB:
    """
    ADB wrapper
    """

    def __init__(self, executable_path: Optional[str] = None):
        """
        :param executable_path: Use this adb binary. If None, look for one in PATH.
        """

        if executable_path is None:
            self.executable = self._findADBPath()

        elif os.path.isfile(executable_path):
            self.executable = executable_path

        if self.executable is None:
            raise ValueError("ADB binary not found!")

    @property
    def _adb_filename(self):
        return "adb.exe" if os.name == "nt" else "adb"

    @property
    def _path_separator(self):
        """
        Used for splitting paths in PATH.
        """

        return ';' if os.name == "nt" else ':'

    def _findADBPath(self) -> str | None:
        """
        Find ADB in PATH. If not found, returns None.
        """

        paths = os.getenv("PATH", "").split(self._path_separator)
        paths.insert(0, os.getcwd())  # Also check the current directory for the binary.
        for path in paths:
            possible_adb_path = os.path.join(path, self._adb_filename)
            if os.path.isfile(possible_adb_path):
                return possible_adb_path

    def getDeviceInfo(self) -> list[dict]:
        """
        Return a list of device information connected.
        """

        cmd_output = subprocess.getoutput(f"{self.executable} devices -l")
        result = []
        for line in cmd_output.split('\n'):
            if line.startswith("List of devices attached") or len(line) == 0:
                # skip header and empty lines
                continue

            result.append({
                "id": line.partition(' ')[0],
                "usb": line.partition("usb:")[2].partition(' ')[0],
                "product": line.partition("product:")[2].partition(' ')[0],
                "model": line.partition("model:")[2].partition(' ')[0],
                "device": line.partition("device:")[2].partition(' ')[0],
                "transport_id": line.partition("transport_id:")[2].partition(' ')[0]
            })

        return result


class Device(ADB):
    def __init__(self, device_id: str, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self._device_id = None

        # Check if device is connected
        for device_info in self.getDeviceInfo():
            if device_id.upper() == device_info["id"]:
                self._device_id = device_id.upper()

        if self.device_id is None:
            raise ValueError(f"Cannot connect to device with ID `{device_id}`.")

    @property
    def device_id(self) -> str | None:
        return self._device_id

    def _buildCommand(self, *args) -> str:
        base = f"{self.executable} -s {self.device_id}"
        return f"{base} {' '.join(args)}"

    def _uninstallPackage(self, package_name: str, user: Optional[str] = None) -> str:
        """
        Uninstall <package_name> for user <user>.
        """

        command: list = ["shell pm uninstall"]
        if user is not None:
            command.append(f"--user {user}")

        command.append(package_name)
        return subprocess.getoutput(self._buildCommand(*command))

    def _disablePackage(self, package_name: str, user: Optional[str] = None) -> str:
        """
        Disable <package_name> for user <user>.
        """

        command: list = ["shell pm disable"]
        if user is not None:
            command.append(f"--user {user}")

        command.append(package_name)
        return subprocess.getoutput(self._buildCommand(*command))

    def _disableUserPackage(self, package_name: str, user: Optional[str] = None) -> str:
        """
        Disable <package_name> for user <user>.
        """

        command: list = ["shell pm disable-user"]
        if user is not None:
            command.append(f"--user {user}")

        command.append(package_name)
        return subprocess.getoutput(self._buildCommand(*command))

    def _listInstalledPackages(self, user: Optional[str] = None, *args) -> list[str]:
        """
        Get a list of packages for user <user>.
        """

        command: list = ["shell cmd package list packages"]
        if user is not None:
            command.append(f"--user {user}")

        for arg in args:
            command.append(arg)

        return [item.partition('package:')[2] for item in subprocess.getoutput(self._buildCommand(*command)).split('\n')]

    def getUsers(self) -> list[dict]:
        """
        Return a list of users that exist in <device>.
        """

        cmd_output = subprocess.getstatusoutput(f"{self.executable} -s {self.device_id} shell pm list users")
        result = []
        for line in cmd_output[1].split('\n'):
            if line.startswith("Users:") or len(line) == 0:
                continue

            result.append({
                "id": line.partition("UserInfo{")[2].partition(':')[0],
                "name": line.partition(':')[2].partition(':')[0],
                "flags": line[::-1].partition(':')[0][::-1].partition('}')[0],
                "status": line.partition('} ')[2]
            })

        return result

    def getPackages(self, user: Optional[str] = None) -> list[list[str | dict]]:
        packages = []
        user_packages = self._listInstalledPackages(user, "-3")
        system_packages = self._listInstalledPackages(user, "-s")

        enabled_packages = self._listInstalledPackages(user, "-e")
        disabled_packages = self._listInstalledPackages(user, "-d")

        all_packages = set(user_packages) | set(system_packages) | set(enabled_packages) | set(disabled_packages)
        uninstalled_packages = list(set(self._listInstalledPackages(user, "-u")) - set(all_packages))

        for package in set(all_packages) | set(uninstalled_packages):
            packages.append([
                package,
                {
                    "type": "user" if package in user_packages else "system",
                    "enabled": package not in disabled_packages,
                    "uninstalled": package in uninstalled_packages
                    # All possible switches:
                    # "user_package": package in user_packages,
                    # "system_package": package in system_packages,
                    # "enabled_package": package in enabled_packages and package not in disabled_packages,
                    # "disabled_package": package in disabled_packages,
                    # "uninstalled_packages": package in uninstalled_packages
                }
            ])

        return packages

    def removeOrDisable(self, package_name: str) -> str:
        """
        Attemps to uninstall or disable the package in the following order:
        uninstall -> disable -> disable-user
        """

        # FIXME: User ID is hardcoded (0) which may differ from phone to phone.
        cmd_output = self._uninstallPackage(package_name, '0')
        if "fail" not in cmd_output.lower() and "error" not in cmd_output.lower():
            return f"[uninstall] {cmd_output}"

        cmd_output = self._disablePackage(package_name, '0')
        if "fail" not in cmd_output.lower() and "error" not in cmd_output.lower():
            return f"[disable] {cmd_output}"

        cmd_output = self._disableUserPackage(package_name, '0')
        if "fail" not in cmd_output.lower() and "error" not in cmd_output.lower():
            return f"[disable-user] {cmd_output}"

        return "[E] Unable to uninstall nor disable the package."


if __name__ == "__main__":
    try:
        try:
            adb = ADB()

        except ValueError:
            try:
                adb = ADB(InputBox(PROGRAM_NAME, "ADB Path not detected!\nPlease enter the path of your ADB binary.")())

            except ValueError:
                print("[CRITICAL] The ADB path you entered does not exist. Please download the Android Debug Bridge (ADB) binary and try again.")
                sys.exit(1)

        # ? Choose device to modify
        while True:
            print("[i] Scanning for devices...")
            devices = adb.getDeviceInfo()
            device_choices = {
                str(idx + 1): f"{dev_info['device']} {dev_info['model']} ({dev_info['id']})"
                for idx, dev_info in enumerate(devices)
            }
            chosen_device = devices[
                int(Choices(
                    device_choices,
                    PROGRAM_NAME,
                    "Please select a device to modify.\nNOTE: CREATE A BACKUP OF YOUR DATA FIRST"
                )()) - 1
            ]
            if Choices(
                {'Y': "Yes", 'N': "No"},
                PROGRAM_NAME,
                "{0}\n{1}".format(
                    "Are you sure that you want to modify the following device?",
                    f"{chosen_device['device']} {chosen_device['model']} ({chosen_device['id']})"
                )
            )().lower() == 'y':
                break

        device = Device(chosen_device["id"], adb.executable)
        # ? Get packages to uninstall/disable
        while True:
            if Choices(
                {"F": "Use a file containing a list of package names", "M": "Manually enter package names"},
                PROGRAM_NAME,
                "How are we going to determine which packages to uninstall/disable?"
            )().lower() == 'f':
                filepath = InputBox(
                    PROGRAM_NAME,
                    input_prompt="Enter the filepath >>> "
                )()
                try:
                    with open(filepath, 'r') as f:
                        packages_to_remove = f.read().split()

                    break

                except FileNotFoundError:
                    print("[ERROR] File does not exist.")
                    confirm()

            else:
                package = InputBox(
                    PROGRAM_NAME,
                    "Enter the packages to uninstall/disable below. Package names can be separated by a semicolon (;)"
                )().replace(' ', '')
                packages_to_remove: list[str] = package.split(';') if ';' in package else [package]
                break

        clearScreen()
        for pkg in packages_to_remove:
            print(pkg)

        print()
        print(f"{len(packages_to_remove)} package(s) will be uninstalled/disabled.")
        print("Enter `continue` to start the operation.\n")
        if input(" >>> ") != "continue":
            print("\nOperation cancelled.")
            sys.exit(3)

        print()
        print("Uninstalling/disabling packages...")
        # ? Perform the operations
        results = []
        for idx, package in enumerate(packages_to_remove):
            print(f"Attempting to uninstall or disable `{package}`")
            results.append((package, device.removeOrDisable(package)))

        print()
        for result in results:
            print(f"{result[0]}: {result[1]}")

    except KeyboardInterrupt:
        print("\n\n[!] CTRL+C detected, exiting...")
        sys.exit(2)
