"""
I used this script to automatically change the sensitivity
settings of osu! when I am using a graphic tablet.

Mouse playstyle sensitivity:  2.00
Tablet playstyle sensitivity: 4.50
"""

import os
import sys


class Main:
    def __init__(self):
        self.configfile = "E:/Others/osu!/osu!.<username>.cfg"
        self.placeholder = "<username>"
        self.username = "Chris"  # Windows username
        self.preferred_sensitivities = ("2.00", "4.50")  # Let's make this a tuple of strings with two variables
                                                         # so we won't need to worry about losing decimal places.
                                                         # In other words, let's hardcode this because we're lazy.
        self.key = "MouseSpeed"

    def main(self):
        """
        Changes MouseSpeed in config file.
        """

        # self.username = str(input("Enter your Windows username: "))
        self.userconfig = self.configfile.replace(self.placeholder, self.username)
        if os.path.exists(self.userconfig):
            with open(self.userconfig, 'r') as f:
                current_config = f.readlines()

            new_config = ""
            for line in current_config:
                if line.startswith(self.key):
                    current_value = line.partition(" = ")[2].replace('\n', '')
                    if str(self.preferred_sensitivities[0]).startswith(current_value):
                        print(
                            "[WARNING] Changing current value ({0}) to new value ({1}).".format(
                                current_value,
                                self.preferred_sensitivities[1]
                            )
                        )
                        new_value = self.preferred_sensitivities[1]

                    else:
                        print(
                            "[WARNING] Changing current value ({0}) to new value ({1}).".format(
                                current_value,
                                self.preferred_sensitivities[0]
                            )
                        )
                        new_value = self.preferred_sensitivities[0]

                    newline = "MouseSpeed = {0}\n".format(new_value)

                else:
                    newline = line

                new_config += newline

            with open(self.userconfig, 'w') as f:
                f.write(new_config)

            print("[i] Done!")
            return 0

        else:
            print("Wrong username? (File `{0}` does not exist)".format(self.userconfig))
            return 1


if __name__ == "__main__":
    sys.exit(Main().main())
