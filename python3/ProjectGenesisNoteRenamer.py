#!/usr/bin/env python3

"""
Rename files in format `./YYYY/MM - MMMM/DD.md` to `./YYYY/MM - MMMM/YYYY-MM-DD.md`.
"""

import os
import sys
import shutil
import traceback


class Main:
    def __init__(self):
        """
        The initialization method of Main() class.
        """

        self.template = {
            # 2021/10 - October/2021-10-24
            #
            # YYYY - Year in Decimal Format  (2021)
            # mm   - Month in Decimal Format (10)
            # MMMM - Month in Text Format    (October)
            # DD   - Day in Decimal Format   (24)

            "from": "YYYY/mm - MMMM/DD",
            "to": "YYYY/mm - MMMM/YYYY-MM-DD"
        }
        self.genesis = "."  # The path where the files are located.
        self.future = ".new"  # The path where new files will be written.

    def check(self, x: str, l: int = 2):
        while len(x) < l:
            x = f"0{x}"  # Add padding to <x> consisting of 0s.

        return x

    def main(self):
        years = os.listdir(self.genesis)
        for year in years:
            print(f"[YEAR] Processing {year}")
            try:
                if len(str(int(year))) == 4:
                    months = os.listdir(os.path.join(self.genesis, year))
                    for month in months:
                        print(f"[MONTH] Processing {month}")
                        if month.startswith(tuple(map(lambda x: self.check(str(x)), range(1, 13)))):
                            days = os.listdir(os.path.join(self.genesis, year, month))
                            for day in days:
                                os.makedirs(os.path.join(self.future, year, month), exist_ok=True)
                                print("[COPY] Copying `{0}` to `{1}`...".format(os.path.join(self.genesis, year, month, day), os.path.join(self.future, year, month, f"{year}-{month.partition(' - ')[0]}-{day}")))
                                shutil.copy2(os.path.join(self.genesis, year, month, day), os.path.join(self.future, year, month, f"{year}-{month.partition(' - ')[0]}-{day}"))

                else:
                    print("[SKIP] Skipping year.")
                    continue

            except ValueError:
                print("[SKIP] Skipping year.")
                continue

        return 0


if __name__ == "__main__":
    error_code = 11
    try:
        error_code = Main().main()

    except BaseException as e:
        print("CRITICAL:", e)
        print('=' * 50)
        traceback.print_exc()
        print('=' * 50)
        error_code = 10

    finally:
        print(f"Program exited with error code #{error_code}.")
        sys.exit(error_code)
