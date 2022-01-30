####################################################
###                                              ###
### THIS FILE WAS MADE BY u/Mino260806 ON REDDIT ###
### PLEASE CREDIT THE AUTHOR IN CASE YOU WANT TO ###
###         PUBLISH IT IN ANY WAY                ###
###                                              ###
####################################################

# Modified by CodeFix1027 for prettier (subjectively) output.
# Original post: https://www.reddit.com/r/PiratedGames/comments/p7c4a6/finally_minecraft_windows_10_crack/

import os
import re
import sys
import time
import subprocess

NAME = "Minecraft"

# ==================== Editable variables ====================

interval = 5  # How often do we need to check for the processes?

auto_reg = True  # Automatically enable the crack when starting?
                 # NOTE: Crack will not be disabled if closed using the `X` button in the window.
                 #       You should press CTRL+C or auto_close feature for this to work.

auto_close = True  # True if you want to auto-close this script.
max_closed = 2  # How many times should the script check for Minecraft process' existence before exiting?

# ==================== Editable variables ====================

# This will override variables above.
if "--auto_reg" in sys.argv:
    auto_reg = True

if "--auto_close" in sys.argv:
    auto_close = True


# This is used only if auto_reg is True.
class CrackApplicator():
    """
    This class is responsible for applying and reverting the crack.
    """

    def __init__(self):
        """
        The initialization method of CrackApplicator() class.
        """

        self.temp_dir = os.getenv("TEMP")  # This is where we will put the temporary files.
        self.enable_reg_path = f"{self.temp_dir}\\mc_enable.reg"
        self.disable_reg_path = f"{self.temp_dir}\\mc_disable.reg"

        self.enable_reg = rb"""Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\ClipSVC\Parameters]
"DisableSubscription"=dword:00000000
"InactivityShutdownDelay"=dword:0000012c
"RefreshRequired"=dword:00000001
"ServiceDll"=hex(2):25,00,53,00,79,00,73,00,74,00,65,00,6d,00,52,00,6f,00,6f,\
  00,74,00,25,00,5c,00,53,00,79,00,73,00,74,00,65,00,6d,00,33,00,32,00,5c,00,\
  43,00,6c,00,69,00,70,00,53,00,56,00,43,00,2e,00,64,00,6c,00,6c,00,61,00,00,\
  00
"ServiceDllUnloadOnStop"=dword:00000001
"ProcessBiosKey"=dword:00000001
"""
        self.disable_reg = rb"""Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\ClipSVC\Parameters]
"DisableSubscription"=dword:00000000
"InactivityShutdownDelay"=dword:0000012c
"RefreshRequired"=dword:00000001
"ServiceDll"=hex(2):25,00,53,00,79,00,73,00,74,00,65,00,6d,00,52,00,6f,00,6f,\
  00,74,00,25,00,5c,00,53,00,79,00,73,00,74,00,65,00,6d,00,33,00,32,00,5c,00,\
  43,00,6c,00,69,00,70,00,53,00,56,00,43,00,2e,00,64,00,6c,00,6c,00,00,00
"ServiceDllUnloadOnStop"=dword:00000001
"ProcessBiosKey"=dword:00000001
"""

    def enable(self):
        """
        Enable the crack.

        :returns bool: Returns True if successful.
        """

        with open(self.enable_reg_path, 'wb') as f:
            f.write(self.enable_reg)  # Create the temporary registry file.

        try:
            os.startfile(self.enable_reg_path)  # Start the registry file.

        except(FileNotFoundError, OSError):
            return False

        else:
            return True

    def disable(self):
        """
        Disable the crack.

        :returns bool: Returns True if successful.
        """

        with open(self.disable_reg_path, 'wb') as f:
            f.write(self.disable_reg)  # Create the temporary reg file.

        try:
            os.startfile(self.disable_reg_path)  # Start the reg file.

        except(FileNotFoundError, OSError):
            return False

        else:
            return True

    def cleanup(self):
        """
        Remove the temporary files.

        :returns void:
        """

        try:
            os.remove(self.enable_reg_path)

        except(FileNotFoundError):
            pass

        except IOError as e:
            print("[!] Unable to delete `{0}` ({1})".format(self.enable_reg_path, e))

        try:
            os.remove(self.disable_reg_path)

        except(FileNotFoundError):
            pass

        except IOError as e:
            print("[!] Unable to delete `{0}` ({1})".format(self.disable_reg_path, e))


def shell_check_output(command):
    """
    Run command via subprocess.

    :param str command: The command to run.

    :returns str: The output of the command.
    """

    return subprocess.check_output(command, shell=True).decode("utf-8", "ignore").split('\r\n')

def call_disable_reg():
    """
    Call `CrackApplicator().disable()` and `CrackApplicator().cleanup()`.

    :returns void:
    """

    if auto_reg:
        print("[i] Disabling the crack...")
        if CrackApplicator().disable():
            print("[i] Success!")

        else:
            print("[E] Failed to disable the crack.")

        input("Allow registry update and press enter to continue...")
        CrackApplicator().cleanup()

def main():
    """
    The main function of the script.

    :returns int: The error code.
    """

    pne_counter = 0  # Used for counting how many times Minecraft isn't seen in the tasks list.
    separator = '=' * 20  # Separator for the outputs.

    print()
    print(NAME)
    print()

    # Automatically enable the crack (if enabled)
    if auto_reg:
        print("[i] Enabling the crack...")
        if CrackApplicator().enable():
            print("[i] Success! You can now run Minecraft.")
            input("Press enter to continue...")

        else:
            print("[E] Failed to apply the crack.")
            if input("Type in `y` to continue; To quit, leave it empty and press enter: ").lower() != 'y':
                return 1

    print()
    if auto_reg:
        print("[i] You can now play Minecraft. Press CTRL+C to stop and disable crack.")

    else:
        print("[i] You can now play Minecraft. Press CTRL+C to stop.")

    print()

    # RuntimeBroker.exe monitor
    try:
        print(separator)
        while True:
            tasks = shell_check_output("tasklist /apps")  # Get process list.
            found = False

            for i, task in enumerate(tasks):  # i = index; task = line data
                if "RuntimeBroker.exe" in task and "MinecraftUWP" in task:
                    pid = re.search(r' (\d+) ', task).group(1)
                    print(f"[i] RuntimeBroker.exe related to MinecraftUWP detected. (PID {pid})")
                    output = shell_check_output(f'taskkill /f /pid {pid}')
                    print(f"[i] {output[0]}")
                    print(separator)
                    found = True  # To be used in after the for loop.

            if auto_close and not found:  # Check Minecraft process if RuntimeBroker is not found above.
                process_exists = False
                for i, task in enumerate(tasks):
                    if "Minecraft.Windows.exe (App)" in task and "MinecraftUWP" in task:
                        process_exists = True
                        break

                if not process_exists:  # If Minecraft process doesn't exist, increment pne_counter.
                    pne_counter += 1
                    print(f"[i] Minecraft process not found, getting ready to disable crack... ({pne_counter}/{max_closed})")
                    if pne_counter == max_closed:
                        call_disable_reg()
                        return 0  # Exit the program when the counter is equal to maximum retry.

                else:
                    # Reset the counter.
                    pne_counter = 0

            time.sleep(interval)  # Wait for <interval> seconds.

    except(KeyboardInterrupt):
        print("[i] CTRL+C detected, now quitting.")

        # Automatically disable the crack (if enabled)
        call_disable_reg()
        return 0

if __name__ == "__main__":
    sys.exit(main())  # Start main() function.
