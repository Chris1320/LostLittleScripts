#!/usr/bin/env python3

"""
WIP:

DATE

GRADE

`NONE` ENTRIES
"""

import os
import sys
import json
import shutil
import traceback


class Main():
    def __init__(self):
        """
        The initialization method of Main() class.
        """

        self.PROGRAM_NAME = "Universum2Obsidian"
        self.PROGRAM_DESC = "Convert Universum JSON to Obsidian Markdown."
        self.PROGRAM_VERT = (1, 5, 6)
        self.PROGRAM_VERS = '.'.join(map(str, self.PROGRAM_VERT))

        self.files: dict[str, str | None] = {
            "universum": None,
            "obsidian": None
        }

        # The markdown template to use.
        self.md_template = """# Day Information

- Date: {0}-{1}-{2}

## Grade

- [ ] 1 - Very Bad
- [ ] 2 - Bad
- [ ] 3 - Average
- [ ] 4 - Good
- [ ] 5 - Excellent

# Daily Entry
"""

        self.obsidian_media_temp = "{0}/Media"
        self.sep = '/'
        self.logfile = "logfile.dat"

    def pause(self, prompt: str = "Press enter to continue...") -> None:
        """
        Wait for user input.

        :param prompt: The prompt to show to the user.
        """

        input(prompt)

        return None

    def show(self, *args: str) -> None:
        """
        Print <args> and log it to <self.logfile>.

        :param *args: Strings to print.
        """

        result = ' '.join(map(str, args))

        print(result)
        with open(self.logfile, 'ab') as f:
            f.write("{0}{1}".format(result, '\n').encode("utf-8"))

    def main(self):
        """
        The main method of Main() class.

        :returns int: Error code.
        """

        self.show("{0} v{1}".format(self.PROGRAM_NAME, self.PROGRAM_VERS))
        self.show(self.PROGRAM_DESC)
        self.show()
        # Clear past logs
        with open(self.logfile, 'w') as f:
            f.write('')

        try:
            self.files["universum"] = sys.argv[1]

        except IndexError:
            self.files["universum"] = input("Enter the path of the folder of the Universum backups: ")

        try:
            self.files["obsidian"] = sys.argv[2]

        except IndexError:
            self.files["obsidian"] = input("Enter the path of the Obsidian folder: ")

        # * Check if the entered paths exist.
        if os.path.exists(self.files["universum"]) and os.path.exists(self.files["obsidian"]):
            self.obsidian_media_temp = self.obsidian_media_temp.format(self.files["obsidian"])
            self.show("[i] Starting conversion process...")
            # * Read Universum JSON data for transfer.
            with open("{0}{1}data.pr".format(self.files["universum"], self.sep), encoding="utf8") as fopen:
                udata = json.load(fopen)  # Read the file.

            # Get Universum entries
            entries = udata["marks"]
            i = 0  # Iterator
            # * Start the conversion.
            while i < len(entries):
                self.show(f"[i] Processing entry #{i + 1} of {len(entries)}...")
                # NOTE: Temporarily commented the line below
                # f = lambda x: time.strftime('%m/%d/%Y %H:%M:%S',  time.gmtime(x/1000.))
                entry = entries[i]  # Get the entry.
                entry_data: dict[str, str | None] = {  # Setup template for data of entry
                    "date": None,
                    "time": None,
                    "comment": None,
                    "photo": None,
                    "paint": None,
                    "grade": None
                }

                try:
                    # * Get entry data.
                    entry_data["date"] = entry["date"].split('-')  # Date as (YYYY, MM, DD)
                    entry_data["time"] = entry["time"].split(':')  # Time as (HH, MM, SS)
                    try:
                        entry_data["comment"] = entry["comment"]

                    except KeyError:
                        pass  # The entry doesn't have a comment.

                    try:
                        entry_data["photo"] = "{0}.jpg".format(entry["photo"].partition("Photo/")[2])

                    except KeyError:
                        pass  # The entry doesn't have a photo attached.

                    try:
                        entry_data["paint"] = "{0}.png".format(entry["paint"].format(entry["paint"].partition("Paint/")[2]))

                    except KeyError:
                        pass  # The entry doesn't have a painting attached.

                    try:
                        entry_data["grade"] = entry["grade"]

                    except KeyError:
                        pass  # The entry doesn't have a grade.

                    if entry_data["comment"] is None:
                        if entry_data["grade"] is None:
                            if entry_data["paint"] is None:
                                raise ValueError("What the heck is this entry?!")

                    result = ""  # For later markdown creation
                    # * Create file if it doesn't exist
                    # Check if year folder in Obsidian directory exists. It loops until the desired file structure is achieved.
                    while True:
                        if os.path.isdir("{0}{1}{2}".format(self.files["obsidian"], self.sep, entry_data["date"][0])):
                            # Check if year/month folder in Obsidian directory exists.
                            if os.path.isdir("{0}{1}{2}{1}{3}".format(self.files["obsidian"], self.sep, entry_data["date"][0], entry_data["date"][1])):
                                # Check if year/month/day file in Obsidian directory exists.
                                if os.path.isfile("{0}{1}{2}{1}{3}{1}{4}.md".format(self.files["obsidian"], self.sep, entry_data["date"][0], entry_data["date"][1], entry_data["date"][2])):
                                    break

                                else:
                                    # If file doesn't exist, make it.
                                    with open("{0}{1}{2}{1}{3}{1}{4}.md".format(self.files["obsidian"], self.sep, entry_data["date"][0], entry_data["date"][1], entry_data["date"][2]), 'w') as f:
                                        f.write(self.md_template.format(entry_data["date"][0], entry_data["date"][1], entry_data["date"][2]))

                            else:
                                # If month folder doesn't exist, create it.
                                os.mkdir("{0}{1}{2}{1}{3}".format(self.files["obsidian"], self.sep, entry_data["date"][0], entry_data["date"][1]))

                        else:
                            # If year folder doesn't exist, create it.
                            os.mkdir("{0}{1}{2}".format(self.files["obsidian"], self.sep, entry_data["date"][0]))

                    # * Embedding media to markdown, opening the file, and saving data to it.
                    with open("{0}{1}{2}{1}{3}{1}{4}.md".format(self.files["obsidian"], self.sep, entry_data["date"][0], entry_data["date"][1], entry_data["date"][2]), 'ab') as obsidian_f:
                        # If the entry is only a photo/paint and no comments, append to last entry.
                        if entry_data["comment"] == "":
                            if not entry_data["photo"] is None:
                                result = "![[{0}]]\n".format(entry_data["photo"])
                                # Copies the file
                                shutil.copy2("{0}{1}Photo{1}{2}".format(self.files["universum"], self.sep, entry_data["photo"].partition(".jpg")[0]), "{0}{1}Photo{1}{2}.jpg".format(self.obsidian_media_temp, self.sep, entry_data["photo"].partition(".jpg")[0]))

                            elif not entry_data["paint"] is None:
                                result = "![[{0}]]\n".format(entry_data["paint"].partition("Paint/")[2])
                                # Copies the file
                                shutil.copy2("{0}{1}Paint{1}{2}".format(self.files["universum"], self.sep, entry_data["paint"].partition(".png")[0]), "{0}{1}Photo{1}{2}.png".format(self.obsidian_media_temp, self.sep, entry_data["paint"].partition(".png")[0].partition("Paint/")[2]))

                        # If the entry is a day grading entry, edit the file.
                        elif type(entry_data["grade"]) is int:
                            # Read file.
                            self.show("DEV0005: GRADE DETECTED")
                            with open("{0}{1}{2}{1}{3}{1}{4}.md".format(self.files["obsidian"], self.sep, entry_data["date"][0], entry_data["date"][1], entry_data["date"][2]), 'r', encoding="utf-8") as grade_f:
                                grade_f = grade_f.read()

                                if entry_data["grade"] == 1:
                                    self.show("DEV0005: GRADED 1")
                                    grade_f = grade_f.replace("""[ ] 1 - Very Bad""", """[X] 1 - Very Bad""")

                                elif entry_data["grade"] == 2:
                                    self.show("DEV0005: GRADED 2")
                                    grade_f = grade_f.replace("""[ ] 2 - Bad""", """[X] 2 - Bad""")

                                elif entry_data["grade"] == 3:
                                    self.show("DEV0005: GRADED 3")
                                    grade_f = grade_f.replace("""[ ] 3 - Average""", """[X] 3 - Average""")

                                elif entry_data["grade"] == 4:
                                    self.show("DEV0005: GRADED 4")
                                    grade_f = grade_f.replace("""[ ] 4 - Good""", """[X] 4 - Good""")

                                elif entry_data["grade"] == 5:
                                    self.show("DEV0005: GRADED 5")
                                    grade_f = grade_f.replace("""[ ] 5 - Excellent""", """[X] 5 - Excellent""")

                                else:
                                    raise ValueError("What is this grade?!")

                            with open("{0}{1}{2}{1}{3}{1}{4}.md".format(self.files["obsidian"], self.sep, entry_data["date"][0], entry_data["date"][1], entry_data["date"][2]), 'wb') as grade_fw:
                                grade_fw.write(grade_f.encode("utf-8"))

                            i += 1
                            continue

                        else:
                            if entry_data["comment"] in ("None", ' ', None):
                                entry_data["comment"] = ''

                            else:
                                entry_data["comment"] += '\n'  # type: ignore

                            final_media = ""
                            # If entry has media, add it to markdown.
                            if not entry_data["photo"] is None:
                                final_media = """
![[{0}]]
""".format(entry_data["photo"])
                                shutil.copy2("{0}{1}Photo{1}{2}".format(self.files["universum"], self.sep, entry_data["photo"].partition(".jpg")[0]), "{0}{1}Photo{1}{2}.jpg".format(self.obsidian_media_temp, self.sep, entry_data["photo"].partition(".jpg")[0]))

                            elif not entry_data["paint"] is None:
                                final_media = """
![[{0}]]
""".format(entry_data["paint"])
                                shutil.copy2("{0}{1}Paint{1}{2}".format(self.files["universum"], self.sep, entry_data["paint"].partition(".png")[0].partition("Paint/")[2]), "{0}{1}Photo{1}{2}.png".format(self.obsidian_media_temp, self.sep, entry_data["paint"].partition(".png")[0].partition("Paint/")[2]))

                            result = """## {0}:{1}:{2}
{3}
{4}
""".format(entry_data["time"][0], entry_data["time"][1], entry_data["time"][2], final_media, entry_data["comment"])

                        self.show("#{0}:{1}:{2}None".format(entry_data["time"][0], entry_data["time"][1], entry_data["time"][2], final_media, entry_data["comment"]).replace(' ', '').replace('\n', ''))
                        self.show(result.replace('\n', '').replace(' ', ''))
                        if result is None or \
                            result == "None" or \
                                result.replace('\n', '').replace(' ', '') == "##{0}:{1}:{2}None".format(entry_data["time"][0], entry_data["time"][1], entry_data["time"][2], final_media, entry_data["comment"]).replace(' ', '').replace('\n', '') or \
                                result.replace('\n', '').replace(' ', '') == "##{0}:{1}:{2}".format(entry_data["time"][0], entry_data["time"][1], entry_data["time"][2]).replace(' ', '').replace('\n', ''):

                            pass

                        else:
                            result = result.encode("utf-8")

                            self.show('=' * 25)
                            try:
                                self.show(result.decode("utf-8"))

                            except UnicodeDecodeError:
                                pass

                            self.show('=' * 25)

                            # * Write to markdown file.
                            obsidian_f.write(result)

                except Exception as e:
                    self.show("[E] {0}".format(e))
                    self.show()
                    self.show(traceback.format_exc())
                    self.show()
                    err_cont = input("Continue operation? (y/n): ")
                    if err_cont.lower().startswith('y'):
                        continue

                    else:
                        break

                i += 1

        else:
            self.show("[E] Either the Universum of Obsidian path is incorrect or doesn't exist.")
            self.show()
            self.pause()
            return 1


if __name__ == "__main__":
    try:
        error_code = Main().main()
        print(f"Program exited with error code {error_code}.")

    except Exception as e:
        traceback.print_exc()
