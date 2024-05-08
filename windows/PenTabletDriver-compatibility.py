"""
I used this script to automatically toggle Windows Ink compatibility
of my HUION 420 graphic tablet with manufacturer-issued driver.

I now use OpenTabletDriver instead. (https://opentabletdriver.net/)
"""

import os
import sys
import subprocess

# ? `SupportINKDisalbe=1` will enable TabletPC support.


class Main:
    def __init__(self, value: int | None = None):
        self.configfile = "C:/Program Files/PenTabletDriver/tabletconfig.ini"  # Config to modify
        self.process = "TabletDriver.exe"  # Process to kill
        self.path = "C:/ProgramData/Microsoft/Windows/Start Menu/Programs/PenTabletDriver/PenTabletDriver.lnk"  # Executable to start
        self.value = value

    def restart_driver(self):
        subprocess.call(("taskkill", "/IM", self.process, "/F"))
        # time.sleep(3)
        os.startfile(self.path)

    def main(self):
        with open(self.configfile, 'r') as f:
            config = f.readlines()

        newconfig = ""
        for line in config:
            if line.startswith("SupportINKDisalbe="):
                print(f"[i] Detected `SupportINKDisalbe` variable (Value: {int(line.partition('=')[2])})")
                if self.value is None:
                    if int(line.partition('=')[2]) == 0:
                        line = "SupportINKDisalbe=1\n"
                        print("Variable value changed to 1.")

                    else:
                        line = "SupportINKDisalbe=0\n"
                        print("Variable value changed to 0.")

                else:
                    line = f"SupportINKDisalbe={self.value}\n"
                    print(f"Variable value changed to {self.value}.")

            newconfig += f"{line}"

        with open(self.configfile, 'w') as f:
            print("Writing to config file...")
            f.write(newconfig)

        self.restart_driver()
        return 0


if __name__ == "__main__":
    try:
        value = int(sys.argv[1])
        if value not in (0, 1):
            value = None

    except IndexError:
        value = None

    sys.exit(Main(value).main())
