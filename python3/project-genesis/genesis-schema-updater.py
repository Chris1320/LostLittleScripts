#!/usr/bin/env python3

import calendar
import json
import os
import re
import shutil
import sys
import uuid
from datetime import datetime, timedelta
from pathlib import Path
from typing import Final

VAULT_OLD: Final[Path] = Path(os.getcwd(), "Genesis-v1")
VAULT_NEW: Final[Path] = Path(os.getcwd(), "Genesis")
VAULT_NEW_PATH_ENTRIES: Final[Path] = Path(VAULT_NEW, "Entries")
VAULT_NEW_PATH_MEDIA: Final[Path] = Path(VAULT_NEW, "Media")
VAULT_NEW_PATH_PEOPLE: Final[Path] = Path(VAULT_NEW, "People")
VAULT_NEW_PATH_MOOD: Final[Path] = Path(
    VAULT_NEW, "Meta", "Mood", "Data", "mood-tracker-data.json"
)
ENCODING: Final[str] = "utf-8"
MONTHS = {
    1: "01 - January",
    2: "02 - February",
    3: "03 - March",
    4: "04 - April",
    5: "05 - May",
    6: "06 - June",
    7: "07 - July",
    8: "08 - August",
    9: "09 - September",
    10: "10 - October",
    11: "11 - November",
    12: "12 - December",
}

with open(
    Path(VAULT_NEW, "Meta", "Templates", "Entry.md"), "r", encoding=ENCODING
) as f:
    VAULT_NEW_TEMPLATE_ENTRY: Final[str] = f.read()

with open(Path(VAULT_NEW, "Meta", "Templates", "Note.md"), "r", encoding=ENCODING) as f:
    VAULT_NEW_TEMPLATE_NOTE: Final[str] = f.read()

with open(
    Path(VAULT_NEW, "Meta", "Templates", "Dream.md"), "r", encoding=ENCODING
) as f:
    VAULT_NEW_TEMPLATE_DREAM: Final[str] = f.read()

with open(
    Path(VAULT_NEW, "Meta", "Templates", "Person.md"), "r", encoding=ENCODING
) as f:
    VAULT_NEW_TEMPLATE_PERSON: Final[str] = f.read()

# after trying to follow the principles of functional programming,
# i finally give up and use this global variable to track moved
# media files.
media_files: dict[str, Path] = {}
imported_media_files: list[str] = []
for root, _, files in os.walk(Path(VAULT_OLD, "Media")):
    for f in files:
        media_files[f] = Path(root, f)

# for print debugging only
_print = print


def print(*args):
    _print(" ".join(args))
    with open("out.txt", "a", encoding=ENCODING) as f:
        f.write(" ".join(args) + "\n")


def main() -> int:
    """
    This is the main function of the script that scans for entries from the old
    Genesis vault, and passes each found file to the importer.

    :return int: The exit code.
    """

    total_files = 0
    stats: dict[str, int] = {}
    failed_files: dict[str, list[Path]] = {}
    with open(VAULT_NEW_PATH_MOOD, "r") as f:
        # load mood data to memory so that we write it to file only once.
        mood_data: list[dict[str, str | int | list[str]]] = json.load(f)

    for year in map(str, range(2016, 2025)):
        year_dir = Path(VAULT_OLD, year)
        if not year_dir.is_dir():
            print(f"WARNING: cannot find {year_dir}")
            continue

        print(f"INFO: Checking for months in {year_dir}")
        for month_short, month_long in MONTHS.items():
            month_short = str(month_short).zfill(2)
            month_dir = Path(year_dir, month_long)
            if not month_dir.is_dir():
                print(f"WARNING: cannot find {month_dir}")
                continue

            print(f"INFO: Checking for entries in {month_dir}")
            for day in range(
                1, calendar.monthrange(int(year), int(month_short))[1] + 1
            ):
                day = str(day).zfill(2)
                entry = f"{year}-{month_short}-{day}"
                entry_file = Path(month_dir, f"{entry}.md")
                if not entry_file.is_file():
                    print(f"WARNING: the entry for {entry_file} does not exist")
                    continue

                print(f"INFO: Found {entry_file}")
                total_files += 1
                try:
                    process_code, process_msg, stats, mood_data = import_entry(
                        entry_file, stats, mood_data
                    )

                except FileExistsError as e:
                    process_code = 3
                    process_msg = str(e)

                if process_code != 0:
                    if process_msg in failed_files:
                        failed_files[process_msg].append(entry_file)
                    else:
                        failed_files[process_msg] = [entry_file]

            if len(os.listdir(month_dir)) == 0:
                month_dir.rmdir()

        if len(os.listdir(year_dir)) == 0:
            year_dir.rmdir()

    mood_data = sorted(mood_data, key=lambda x: x["dateTime"])
    with open(VAULT_NEW_PATH_MOOD, "w") as f:
        json.dump(mood_data, f, indent=2)

    print(f"INFO: Processed {total_files} files.")
    if len(failed_files) > 0:
        print("\nFailed items:\n")
        for err_msg in failed_files:
            print(err_msg)
            for ff in failed_files[err_msg]:
                print(f"- {ff}")

            print()

    print("\nSummary:")
    for category in stats.keys():
        print(f"{category}: {stats[category]}")

    print()
    return 0


def import_entry(
    entry_filepath: Path,
    stats: dict[str, int],
    mood_data: list[dict[str, str | int | list[str]]],
) -> tuple[int, str, dict[str, int], list[dict[str, str | int | list[str]]]]:
    """
    Import an entry from the old Genesis vault into the new vault.

    :param Path entry_filepath: The filepath of the old entry file.
    :param dict[str, int] stats: The processed files count.
    :return tuple[int, str, list[int]]: The exit code, message, and processed count.
    """

    print("INFO: IMPORTER: Reading file")
    with open(entry_filepath, "r", encoding=ENCODING) as f:
        entry_data = f.read()

    entry_template_version = identify_template(entry_data)
    if entry_template_version == 0.0:
        msg = f"ERROR: IMPORTER: Unknown entry template version"
        stats["unknown"] = stats.get("unknown", 0) + 1
        print(msg)
        return (1, msg, stats, mood_data)

    print(f"INFO: IMPORTER: Detected entry template version: {entry_template_version}")
    stats[f"v{entry_template_version}"] = stats.get(f"v{entry_template_version}", 0) + 1

    if entry_template_version == 0.1:
        code, msg = import_entry_0_1(entry_filepath)
    elif entry_template_version == 0.2:
        code, msg = import_entry_0_2(entry_filepath)
    elif entry_template_version == 0.3:
        code, msg = import_entry_0_3(entry_filepath)
    elif entry_template_version == 0.4:
        code, msg = import_entry_0_4(entry_filepath)
    elif entry_template_version == 0.5:
        code, msg, mood_data = import_entry_0_5(entry_filepath, mood_data)
    elif entry_template_version == 0.6:
        code, msg, mood_data = import_entry_0_6(entry_filepath, mood_data)
    else:
        code = 2
        msg = f"ERROR: IMPORTER: Unknown entry template version on second pass"

    print(msg)
    os.remove(entry_filepath)
    return (code, msg, stats, mood_data)


def identify_template(content: str) -> float:
    """
    Identify what template version the entry was made in.

    :param str content: The content of the entry. (the whole Markdown file content)
    :return int: The version of the template used. Returns 0 if the version is unknown.
    """

    split_content = content.splitlines(True)

    print("INFO: IDENTIFIER: Attempting to identify the template version used")
    if identify_template_0_1(split_content):
        return 0.1
    elif identify_template_0_2(split_content):
        return 0.2
    elif identify_template_0_3(split_content):
        return 0.3
    elif identify_template_0_4(split_content):
        return 0.4
    elif identify_template_0_5(split_content):
        return 0.5
    elif identify_template_0_6(split_content):
        return 0.6
    else:
        return 0.0


def identify_template_0_1(content: list[str]) -> bool:
    """
    Check if the entry content used template v0.1.

    template v0.1:

    ```markdown
    *9 December 2016, Friday*
    # This is The Title of The Entry

    The quick brown fox jumps over the lazy dog.
    ```

    :param list[str] content: The content of the entry
    :return bool: True if the entry was made in template v0.1
    """

    # print("INFO: IDENTIFIER: PARSER: Trying to parse using v0.1")
    try:
        return all(
            [
                re.match(r"^\*(\d{1,2}\s\w+\s\d{4}),\s(\w+)\*$", content[0]),
                re.match(r"^#\s.*$", content[1]),
            ]
        )

    except IndexError:
        # print(
        #     "WARNING: IDENTIFIER: PARSER: IndexError, probably does not use this version"
        # )
        return False


def identify_template_0_2(content: list[str]) -> bool:
    """
    Check if the entry content used template v0.2.

    template v0.2:

    ```markdown
    2 January 2017, Monday

    The quick brown fox jumps over the lazy dog.
    ```

    :param list[str] content: The content of the entry
    :return bool: True if the entry was made in template v0.2
    """

    # print("INFO: IDENTIFIER: PARSER: Trying to parse using v0.2")
    try:
        return re.match(r"^(\d{1,2}\s\w+\s\d{4}),\s(\w+)$", content[0]) is not None

    except IndexError:
        # print(
        #     "WARNING: IDENTIFIER: PARSER: IndexError, probably does not use this version"
        # )
        return False


def identify_template_0_3(content: list[str]) -> bool:
    """
    Check if the entry content used template v0.3.

    template v0.3:

    ```markdown
    *Monday, August 20, 2018*  %% or sometimes %% *14 August 2018, Tuesday*

    %% newlines are variable %%

    **Friends**

    %%newlines are variable %%

    The quick brow fox jumps over the lazy dog.
    ```

    :param list[str] content: The content of the entry.
    :return bool: True if the entry was made in template v0.3
    """

    # print("INFO: IDENTIFIER: PARSER: Trying to parse using v0.3")
    found_date = False
    found_title = False

    for line in content:
        if re.match(r"^\*(\w+),\s(\w+\s\d{1,2},\s\d{4})\*$", line) or re.match(
            r"^\*\d{1,2}\s\w+\s\d{4},\s\w+\*$", line
        ):
            found_date = True
            continue

        if found_date:
            if re.match(r"^\*\*.*\*\*$", line):
                found_title = True
                break

    return found_date and found_title


def identify_template_0_4(content: list[str]) -> bool:
    """
    Check if the entry content used template v0.4.

    template v0.4:

    ```markdown
    *Monday, September 10, 2018*

    # The title here

    The quick brown fox jumps over the lazy dog.
    ```

    :param list[str] content: The content of the entry.
    :return bool: True if the entry was made in template v0.4
    """

    # print("INFO: IDENTIFIER: PARSER: Trying to parse using v0.4")
    try:
        return all(
            [
                re.match(r"^\*(\w+),\s(\w+\s\d{1,2},\s\d{4})\*$", content[0]),
                re.match(r"^#\s.*$", content[2]),
            ]
        )

    except IndexError:
        # print(
        #     "WARNING: IDENTIFIER: PARSER: IndexError, probably does not use this version"
        # )
        return False


def identify_template_0_5(content: list[str]) -> bool:
    """
    Check if the entry content used template v0.5.

    template v0.5:

    ```markdown
    # Day Information

    - Date: 2020-02-02
    - Day: Sunday

    ## Grade

    - [ ] 1 - Very Bad
    - [ ] 2 - Bad
    - [ ] 3 - Average
    - [ ] 4 - Good
    - [x] 5 - Excellent

    # Daily Entry
    %%sometimes there is a newline here %%
    ## 00:09:28

    The quick brown fox jumps over the lazy dog.
    ```

    :param list[str] content: The content of the entry.
    :return bool: True if the entry was made in template v0.5
    """

    # print("INFO: IDENTIFIER: PARSER: Trying to parse using v0.5")

    def check_grades():
        for line in content[7:12]:
            if re.match(r"^-\s\[(\s|x|X)\]\s(\d{1,2}\s-\s.+)$", line) is None:
                return False

        return True  # fun fact: I forgot to put this statement so I was
        # trying to find where it went wrong for about 20 minutes.

    try:
        return all(
            [
                re.match(r"^#\s(Day\sInformation)$", content[0]),
                re.match(r"^-\sDate:\s\d{4}-\d{2}-\d{2}$", content[2]),
                re.match(r"^-\sDay:\s\w+$", content[3]),
                re.match(r"^##\sGrade$", content[5]),
                check_grades(),
                re.match(r"#\sDaily\sEntry$", content[13]),
            ]
        )

    except IndexError:
        # print(
        #     "WARNING: IDENTIFIER: PARSER: IndexError, probably does not use this version"
        # )
        return False


def identify_template_0_6(content: list[str]) -> bool:
    """
    Check if the entry content used template v0.6.

    template v0.6:

    ```markdown
    ---
    date: 2023-11-25
    day: Saturday
    grade: 3
    ---

    # Daily Entry

    ## 00:22:38

    The quick brown fox jumps over the lazy dog.
    ```

    :param list[str] content: The content of the entry.
    :return bool: True if the entry was made in template v0.6
    """

    # print("INFO: IDENTIFIER: PARSER: Trying to parse using v0.6")

    try:
        return all(
            [
                re.match(r"^date:\s\d{4}-\d{2}-\d{2}$", content[1]),
                re.match(r"^day:\s\w+$", content[2]),
                re.match(r"^grade:\s?\d?$", content[3]),
                re.match(r"^#\sDaily\sEntry$", content[6]),
            ]
        )

    except IndexError:
        # print(
        #     "WARNING: IDENTIFIER: PARSER: IndexError, probably does not use this version"
        # )
        return False


def import_entry_0_1(filepath: Path) -> tuple[int, str]:
    """
    ```markdown
    *9 December 2016, Friday*
    # This is The Title of The Entry

    The quick brown fox jumps over the lazy dog.
    ```
    """

    year, month, day = filepath.stem.split("-")  # YYYY-MM-DD
    hour, minute, second = (18, 00, 00)

    # Step 1: Create entry if it does not yet exist.
    create_entry(int(year), int(month), int(day))

    # Step 2: Add the content.
    with open(filepath, "r", encoding=ENCODING) as f:
        content = strip_first_and_last_empty_lines(f.readlines()[1:])
        create_note(content, int(year), int(month), int(day), hour, minute, second)

    return (0, "INFO: IMPORTER: Imported")


def import_entry_0_2(filepath: Path) -> tuple[int, str]:
    """
    ```markdown
    2 January 2017, Monday

    The quick brown fox jumps over the lazy dog.
    ```
    """

    year, month, day = filepath.stem.split("-")  # YYYY-MM-DD
    hour, minute, second = (18, 00, 00)

    # Step 1: Create entry if it does not yet exist.
    create_entry(int(year), int(month), int(day))

    # Step 2: Add the content.
    with open(filepath, "r", encoding=ENCODING) as f:
        content = strip_first_and_last_empty_lines(f.readlines()[1:])
        create_note(content, int(year), int(month), int(day), hour, minute, second)

    return (0, "INFO: IMPORTER: Imported")


def import_entry_0_3(filepath: Path) -> tuple[int, str]:
    """
    ```markdown
    *Monday, August 20, 2018*  %% or sometimes %% *14 August 2018, Tuesday*

    %% newlines are variable %%

    **Friends**

    %%newlines are variable %%

    The quick brow fox jumps over the lazy dog.
    ```
    """

    year, month, day = filepath.stem.split("-")  # YYYY-MM-DD
    hour, minute, second = (18, 00, 00)

    # Step 1: Create entry if it does not yet exist.
    create_entry(int(year), int(month), int(day))

    # Step 2: Add the content.
    with open(filepath, "r", encoding=ENCODING) as f:
        content = f.readlines()
        found_title = False
        note_content = ""

        for line in content:
            if not found_title:
                matches = re.match(r"\*\*(.*)\*\*", line)

                if matches is not None:
                    found_title = True
                    note_content += f"# {matches.group(1)}\n"

            else:
                note_content += line

    create_note(note_content, int(year), int(month), int(day), hour, minute, second)
    return (0, "INFO: IMPORTER: Imported")


def import_entry_0_4(filepath: Path) -> tuple[int, str]:
    """
    ```markdown
    *Monday, September 10, 2018*

    # The title here

    The quick brown fox jumps over the lazy dog.
    ```
    """

    year, month, day = filepath.stem.split("-")  # YYYY-MM-DD
    hour, minute, second = (18, 00, 00)

    # Step 1: Create entry if it does not yet exist.
    create_entry(int(year), int(month), int(day))

    # Step 2: Add the content.
    with open(filepath, "r", encoding=ENCODING) as f:
        content = f.readlines()
        found_title = False
        note_content = ""

        for line in content:
            if not found_title:
                matches = re.match(r"# (.*)", line)

                if matches is not None:
                    found_title = True
                    note_content += f"# {matches.group(1)}\n\n"

            else:
                note_content += line

    create_note(note_content, int(year), int(month), int(day), hour, minute, second)
    return (0, "INFO: IMPORTER: Imported")


def import_entry_0_5(
    filepath: Path, mood_data: list[dict[str, str | int | list[str]]]
) -> tuple[int, str, list[dict[str, str | int | list[str]]]]:
    """
    ```markdown
    # Day Information

    - Date: 2020-02-02
    - Day: Sunday

    ## Grade

    - [ ] 1 - Very Bad
    - [ ] 2 - Bad
    - [ ] 3 - Average
    - [ ] 4 - Good
    - [x] 5 - Excellent

    # Daily Entry
    %%sometimes there is a newline here %%
    ## 00:09:28

    The quick brown fox jumps over the lazy dog.
    ```
    """

    code = 0
    msg = "INFO: IMPORTER: Imported"

    year, month, day = filepath.stem.split("-")  # YYYY-MM-DD
    metadata_done = False
    first_note = True
    capturing = False

    # Step 1: Create entry if it does not yet exist.
    create_entry(int(year), int(month), int(day))

    # Step 2: Add the content.
    with open(filepath, "r", encoding=ENCODING) as f:
        content = f.readlines()

    # Get the grade of the day.
    grade = -1
    i = 0
    while i < len(content):
        if "- [x]" in content[i].lower() and "] 1 -" in content[i]:
            grade = 1
            break

        elif "- [x]" in content[i].lower() and "] 2 -" in content[i]:
            grade = 2
            break

        elif "- [x]" in content[i].lower() and "] 3 -" in content[i]:
            grade = 3
            break

        elif "- [x]" in content[i].lower() and "] 4 -" in content[i]:
            grade = 4
            break

        elif "- [x]" in content[i].lower() and "] 5 -" in content[i]:
            grade = 5
            break

        i += 1
        if "# Daily Entry" in content[i]:
            metadata_done = True
            break

    if grade != -1:
        mood_data = add_mood(
            grade, datetime(int(year), int(month), int(day), 23, 59, 59), mood_data
        )

    # Create notes
    note = ""
    note_time = None
    while i < len(content):
        # skip processing on metadata section
        if not metadata_done:
            if "# Daily Entry" in content[i]:
                metadata_done = True

            i += 1
            continue

        if first_note and re.match(r"## \d{2}:\d{2}:\d{2}", content[i]):
            capturing = True
            first_note = False
            note_time = datetime.strptime(
                f'{year}-{month}-{day}T{content[i].partition("## ")[2][:8]}',
                r"%Y-%m-%dT%H:%M:%S",
            )
            i += 1
            continue

        if not first_note and re.match(r"## \d{2}:\d{2}:\d{2}", content[i]):
            # save the note to a new file.
            create_note(
                "".join(strip_first_and_last_empty_lines(note.splitlines(True))),
                note_time.year,
                note_time.month,
                note_time.day,
                note_time.hour,
                note_time.minute,
                note_time.second,
            )
            note = ""
            note_time = datetime.strptime(
                f'{year}-{month}-{day}T{content[i].partition("## ")[2][:8]}',
                r"%Y-%m-%dT%H:%M:%S",
            )
            i += 1
            continue

        if capturing:
            note += content[i]

        elif len(content[i].strip()) > 0:
            code += 1
            msg = "WARNING: IMPORTER: There are misplaced lines in this entry. Please double check the contents of the file."

        i += 1

    # flush the last note if there is any.
    if len(note) > 0 and note_time is not None:
        create_note(
            "".join(strip_first_and_last_empty_lines(note.splitlines(True))),
            note_time.year,
            note_time.month,
            note_time.day,
            note_time.hour,
            note_time.minute,
            note_time.second,
        )

    return (code, msg, mood_data)


def import_entry_0_6(
    filepath: Path, mood_data: list[dict[str, str | int | list[str]]]
) -> tuple[int, str, list[dict[str, str | int | list[str]]]]:
    """
    ```markdown
    ---
    date: 2023-11-25
    day: Saturday
    grade: 3
    ---

    # Daily Entry

    ## 00:22:38

    The quick brown fox jumps over the lazy dog.
    ```
    """

    code = 0
    msg = "INFO: IMPORTER: Imported"

    year, month, day = filepath.stem.split("-")  # YYYY-MM-DD
    metadata_done = False
    first_note = True
    capturing = False

    # Step 1: Create entry if it does not yet exist.
    create_entry(int(year), int(month), int(day))

    # Step 2: Add the content.
    with open(filepath, "r", encoding=ENCODING) as f:
        content = f.readlines()

    # Get the grade of the day.
    grade = -1
    i = 6
    grade = (
        int(content[3].partition("grade:")[2].strip())
        if len(content[3].partition("grade:")[2].strip()) != 0
        else grade
    )
    if grade != -1:
        mood_data = add_mood(
            grade, datetime(int(year), int(month), int(day), 23, 59, 59), mood_data
        )

    # Create notes
    note = ""
    note_time = None
    while i < len(content):
        # skip processing on metadata section
        if not metadata_done:
            if "# Daily Entry" in content[i]:
                metadata_done = True

            i += 1
            continue

        if first_note and re.match(r"## \d{2}:\d{2}:\d{2}", content[i]):
            capturing = True
            first_note = False
            note_time = datetime.strptime(
                f'{year}-{month}-{day}T{content[i].partition("## ")[2][:8]}',
                r"%Y-%m-%dT%H:%M:%S",
            )
            i += 1
            continue

        if not first_note and re.match(r"## \d{2}:\d{2}:\d{2}", content[i]):
            # save the note to a new file.
            create_note(
                note,
                note_time.year,
                note_time.month,
                note_time.day,
                note_time.hour,
                note_time.minute,
                note_time.second,
            )
            note = ""
            note_time = datetime.strptime(
                f'{year}-{month}-{day}T{content[i].partition("## ")[2][:8]}',
                r"%Y-%m-%dT%H:%M:%S",
            )
            i += 1
            continue

        if capturing:
            note += content[i]

        elif len(content[i].strip()) > 0:
            code += 1
            msg = "WARNING: IMPORTER: There are misplaced lines in this entry. Please double check the contents of the file."

        i += 1

    # flush the last note if there is any.
    if len(note) > 0 and note_time is not None:
        create_note(
            note,
            note_time.year,
            note_time.month,
            note_time.day,
            note_time.hour,
            note_time.minute,
            note_time.second,
        )

    return (code, msg, mood_data)


def create_entry(year: int, month: int, day: int) -> None:
    filename = to_entry_name(year, month, day)
    entry_filepath = Path(
        VAULT_NEW_PATH_ENTRIES, str(year), MONTHS[month], f"{filename}.md"
    )
    entry_date = datetime.strptime(
        f"{year}-{str(month).zfill(2)}-{str(day).zfill(2)}", r"%Y-%m-%d"
    )

    if not entry_filepath.exists():
        entry_filepath.parent.mkdir(parents=True, exist_ok=True)
        with open(entry_filepath, "w", encoding=ENCODING) as f:
            entry_content = (
                VAULT_NEW_TEMPLATE_ENTRY.replace(
                    '<% moment(tp.file.title, "YYYY-MM-DD").format("YYYY-MM-DD") %>',
                    entry_date.strftime(r"%Y-%m-%d"),
                )
                .replace(
                    '<% moment(tp.file.title, "YYYY-MM-DD").format("dddd") %>',
                    entry_date.strftime(r"%A"),
                )
                .replace(
                    '<% moment(tp.file.title, "YYYY-MM-DD").format("Qo of MMMM YYYY") %>',
                    f"{day_to_ordinal_day(entry_date.day)} of {entry_date.strftime(r'%B %Y')}",
                )
                .replace(
                    '<% moment(tp.file.title, "YYYY-MM-DD").format("YYYY") %>',
                    entry_date.strftime(r"%Y"),
                )
                .replace(
                    '<% moment(tp.file.title, "YYYY-MM-DD").format("MM - MMMM") %>',
                    entry_date.strftime(r"%m - %B"),
                )
                .replace(
                    '<% moment(tp.file.title, "YYYY-MM-DD").subtract(1, \'d\').format("YYYY-MM-DD") %>',
                    (entry_date - timedelta(days=1)).strftime(r"%Y-%m-%d"),
                )
                .replace(
                    '<% moment(tp.file.title, "YYYY-MM-DD").add(1, \'d\').format("YYYY-MM-DD") %>',
                    (entry_date + timedelta(days=1)).strftime(r"%Y-%m-%d"),
                )
            )

            f.write(entry_content)

    os.utime(entry_filepath, (entry_date.timestamp(), entry_date.timestamp()))


def create_note(
    content: str, year: int, month: int, day: int, hour: int, minute: int, second: int
) -> None:
    filename = to_note_name(year, month, day, hour, minute, second)
    note_filepath = Path(
        VAULT_NEW_PATH_ENTRIES,
        str(year),
        MONTHS[month],
        to_entry_name(year, month, day)[:-1],
        "Notes",
        f"{filename}.md",
    )
    note_date = datetime.strptime(
        f"{year}-{str(month).zfill(2)}-{str(day).zfill(2)}T{str(hour).zfill(2)}:{str(minute).zfill(2)}:{str(second).zfill(2)}",
        r"%Y-%m-%dT%H:%M:%S",
    )
    if note_filepath.exists():
        msg = "ERROR: IMPORTER: CREATE_NOTE: A note with the same timestamp already exists!"
        print(msg)
        raise FileExistsError(msg)

    content = update_note_content(content)
    note_filepath.parent.mkdir(parents=True, exist_ok=True)
    with open(note_filepath, "w", encoding=ENCODING) as f:
        f.write(
            (
                VAULT_NEW_TEMPLATE_NOTE.replace(
                    '<% moment(tp.file.title, "YYYY-MM-DD_HH-mm-ss").format("YYYY-MM-DDTHH:mm:ss") %>',
                    note_date.strftime(r"%Y-%m-%dT%H:%M:%S"),
                )
                .replace(
                    '<% moment(tp.file.title, "YYYY-MM-DD_HH-mm-ss").format("dddd") %>',
                    note_date.strftime(r"%A"),
                )
                .replace(
                    '<% moment(tp.file.title, "YYYY-MM-DD").format("YYYY") %>',
                    note_date.strftime(r"%Y"),
                )
                .replace(
                    '<% moment(tp.file.title, "YYYY-MM-DD").format("MM - MMMM") %>',
                    note_date.strftime(r"%m - %B"),
                )
                .replace(
                    '<% moment(tp.file.title, "YYYY-MM-DD").format("YYYY-MM-DD") %>',
                    note_date.strftime(r"%Y-%m-%d"),
                )
                .replace(
                    "%% Your thought here... %%",
                    content if content[-1] != "\n" else content[:-1],
                )
            )
        )

    os.utime(note_filepath, (note_date.timestamp(), note_date.timestamp()))


def to_entry_name(year: int, month: int, day: int):
    """
    Create a filename for an entry without the file extension.

    :param int year: The year the note was created.
    :param int month: The month the note was created.
    :param int day: The day the note was created.
    :return str: The filename
    """

    # 2024-01-20E.md
    return f"{year}-{str(month).zfill(2)}-{str(day).zfill(2)}E"


def to_note_name(
    year: int, month: int, day: int, hour: int, minute: int, second: int
) -> str:
    """
    Create a filename for a note without the file extension.

    :param int year: The year the note was created.
    :param int month: The month the note was created.
    :param int day: The day the note was created.
    :param int hour: The hour the note was created.
    :param int minute: The minute the note was created.
    :param int second: The second the note was created.
    :return str: The filename
    """

    # 2024-01-21_02-23-48N.md
    return f"{year}-{str(month).zfill(2)}-{str(day).zfill(2)}_{str(hour).zfill(2)}-{str(minute).zfill(2)}-{str(second).zfill(2)}N"


def day_to_ordinal_day(day: int) -> str:
    """
    Convert a number into its ordinal form.

    :param int day: The day to convert.
    :return str: The converted form of the day.
    """

    if 10 <= day % 100 <= 20:
        suffix = "th"
    else:
        suffix = {1: "st", 2: "nd", 3: "rd"}.get(day % 10, "th")
    return str(day) + suffix


def strip_first_and_last_empty_lines(content: list[str]) -> str:
    while True:  # strip first empty line
        if len(content[0].strip()) > 0:
            break

        content = content[1:]

    while True:  # strip last empty line
        if len(content[-1].strip()) > 0:
            break

        content = content[:-1]

    return "".join(content)


def add_mood(
    grade: int, dt: datetime, mood_data: list[dict[str, str | int | list[str]]]
) -> list[dict[str, str | int | list[str]]]:
    if grade < 1 or grade > 5:
        raise ValueError("Invalid day grade")

    while True:
        mood_id = str(uuid.uuid4())
        if not any(entry["id"] == mood_id for entry in mood_data):
            break

    mood_data.append(
        {
            "id": mood_id,
            "dateTime": dt.strftime(r"%Y-%m-%dT%H:%M:%S"),
            "moodRating": grade,
            "emotions": [],
            "note": "",
        }
    )

    return mood_data


def update_note_content(content: str) -> str:
    """
    Update elements of the content such as backlinks
    and move linked media files to the new vault.

    :param str content: The content of the note.
    :return str: The modified version of the content.
    """

    r"""
    01. [[2021/03 - March/13]]                                  \[\[(\d{4})\/(\d{2})\s-\s\w+\/(\d{1,2})\]\]
    02. [[2021/03 - March/13|13 March 2021]]                    \[\[(\d{4})\/(\d{2})\s-\s\w+\/(\d{1,2})\|(.*)\]\]
    03. [[2021/03 - March/13#01:02:03]]                         \[\[(\d{4})\/(\d{2})\s-\s\w+\/(\d{1,2})#(\d{2}:\d{2}:\d{2})\]\]
    04. [[2021/03 - March/13#01:02:03|13 March 2021]]           \[\[(\d{4})\/(\d{2})\s-\s\w+\/(\d{1,2})#(\d{2}:\d{2}:\d{2})\|(.*)\]\]
    05. [[2023-04-19]]                                          \[\[(\d{4}-\d{2}-\d{2})\]\]
    06. [[2023-04-19|Wednesday]]                                \[\[(\d{4}-\d{2}-\d{2})\|(.*)\]\]
    07. [[2023-04-19#01:02:03]]                                 \[\[(\d{4}-\d{2}-\d{2})#(\d{2}:\d{2}:\d{2})\]\]
    08. [[2023-04-19#01:02:03|Wednesday]]                       \[\[(\d{4}-\d{2}-\d{2})#(\d{2}:\d{2}:\d{2})\|(.*)\]\]
    09. [[2017/01 - January/2017-01-10]]                        \[\[\d{4}\/\d{2}\s-\s\w+\/(\d{4}-\d{2}-\d{2})\]\]
    10. [[2017/01 - January/2017-01-10|January 10]]             \[\[\d{4}\/\d{2}\s-\s\w+\/(\d{4}-\d{2}-\d{2})\|(.*)\]\]
    11. [[2017/01 - January/2017-01-10#01:02:03]]               \[\[\d{4}\/\d{2}\s-\s\w+\/(\d{4}-\d{2}-\d{2})#(\d{2}:\d{2}:\d{2})\]\]
    12. [[2017/01 - January/2017-01-10#01:02:03|January 10]]    \[\[\d{4}\/\d{2}\s-\s\w+\/(\d{4}-\d{2}-\d{2})#(\d{2}:\d{2}:\d{2})\|(.*)\]\]
    """

    def replace_pattern_1(matches: re.Match[str]) -> str:
        date = datetime.strptime(
            f"{matches.group(1)}-{matches.group(2)}-{matches.group(3)}", r"%Y-%m-%d"
        )
        old = matches.group(0)
        new = f"[[{date.strftime(r'%Y-%m-%d')}E]]"
        print(f"DEBUG: PATTERN: 1: Changed `{old}` to `{new}`")
        return new

    def replace_pattern_2(matches: re.Match[str]) -> str:
        date = datetime.strptime(
            f"{matches.group(1)}-{matches.group(2)}-{matches.group(3)}", r"%Y-%m-%d"
        )
        old = matches.group(0)
        new = f"[[{date.strftime(r'%Y-%m-%d')}E|{matches.group(4)}]]"
        print(f"DEBUG: PATTERN: 2: Changed `{old}` to `{new}`")
        return new

    def replace_pattern_3(matches: re.Match[str]) -> str:
        date = datetime.strptime(
            f"{matches.group(1)}-{matches.group(2)}-{matches.group(3)}T{matches.group(4)}",
            r"%Y-%m-%dT%H:%M:%S",
        )
        note_name = to_note_name(
            date.year, date.month, date.day, date.hour, date.minute, date.second
        )
        old = matches.group(0)
        new = f"[[{note_name}]]"
        print(f"DEBUG: PATTERN: 3: Changed `{old}` to `{new}`")
        return new

    def replace_pattern_4(matches: re.Match[str]) -> str:
        date = datetime.strptime(
            f"{matches.group(1)}-{matches.group(2)}-{matches.group(3)}T{matches.group(4)}",
            r"%Y-%m-%dT%H:%M:%S",
        )
        note_name = to_note_name(
            date.year, date.month, date.day, date.hour, date.minute, date.second
        )
        old = matches.group(0)
        new = f"[[{note_name}|{matches.group(5)}]]"
        print(f"DEBUG: PATTERN: 4: Changed `{old}` to `{new}`")
        return new

    def replace_pattern_5(matches: re.Match[str]) -> str:
        old = matches.group(0)
        new = f"[[{matches.group(1)}E]]"
        print(f"DEBUG: PATTERN: 5: Changed `{old}` to `{new}`")
        return new

    def replace_pattern_6(matches: re.Match[str]) -> str:
        old = matches.group(0)
        new = f"[[{matches.group(1)}E|{matches.group(2)}]]"
        print(f"DEBUG: PATTERN: 6: Changed `{old}` to `{new}`")
        return new

    def replace_pattern_7(matches: re.Match[str]) -> str:
        date = datetime.strptime(
            f"{matches.group(1)}T{matches.group(2)}", r"%Y-%m-%dT%H:%M:%S"
        )
        note_name = to_note_name(
            date.year, date.month, date.day, date.hour, date.minute, date.second
        )
        old = matches.group(0)
        new = f"[[{note_name}]]"
        print(f"DEBUG: PATTERN: 7: Changed `{old}` to `{new}`")
        return new

    def replace_pattern_8(matches: re.Match[str]) -> str:
        date = datetime.strptime(
            f"{matches.group(1)}T{matches.group(2)}", r"%Y-%m-%dT%H:%M:%S"
        )
        note_name = to_note_name(
            date.year, date.month, date.day, date.hour, date.minute, date.second
        )
        old = matches.group(0)
        new = f"[[{note_name}|{matches.group(3)}]]"
        print(f"DEBUG: PATTERN: 8: Changed `{old}` to `{new}`")
        return new

    def replace_pattern_9(matches: re.Match[str]) -> str:
        old = matches.group(0)
        new = f"[[{matches.group(1)}E]]"
        print(f"DEBUG: PATTERN: 9: Changed `{old}` to `{new}`")
        return new

    def replace_pattern_10(matches: re.Match[str]) -> str:
        old = matches.group(0)
        new = f"[[{matches.group(1)}E|{matches.group(2)}]]"
        print(f"DEBUG: PATTERN: 10: Changed `{old}` to `{new}`")
        return new

    def replace_pattern_11(matches: re.Match[str]) -> str:
        date = datetime.strptime(
            f"{matches.group(1)}T{matches.group(2)}", r"%Y-%m-%dT%H:%M:%S"
        )
        note_name = to_note_name(
            date.year, date.month, date.day, date.hour, date.minute, date.second
        )
        old = matches.group(0)
        new = f"[[{note_name}]]"
        print(f"DEBUG: PATTERN: 11: Changed `{old}` to `{new}`")
        return new

    def replace_pattern_12(matches: re.Match[str]) -> str:
        date = datetime.strptime(
            f"{matches.group(1)}T{matches.group(2)}", r"%Y-%m-%dT%H:%M:%S"
        )
        note_name = to_note_name(
            date.year, date.month, date.day, date.hour, date.minute, date.second
        )
        old = matches.group(0)
        new = f"[[{note_name}|{matches.group(3)}]]"
        print(f"DEBUG: PATTERN: 12: Changed `{old}` to `{new}`")
        return new

    result = re.sub(
        r"\[\[(\d{4})\/(\d{2})\s-\s\w+\/(\d{1,2})\]\]", replace_pattern_1, content
    )
    result = re.sub(
        r"\[\[(\d{4})\/(\d{2})\s-\s\w+\/(\d{1,2})\|(.*)\]\]", replace_pattern_2, result
    )
    result = re.sub(
        r"\[\[(\d{4})\/(\d{2})\s-\s\w+\/(\d{1,2})#(\d{2}:\d{2}:\d{2})\]\]",
        replace_pattern_3,
        result,
    )
    result = re.sub(
        r"\[\[(\d{4})\/(\d{2})\s-\s\w+\/(\d{1,2})#(\d{2}:\d{2}:\d{2})\|(.*)\]\]",
        replace_pattern_4,
        result,
    )
    result = re.sub(r"\[\[(\d{4}-\d{2}-\d{2})\]\]", replace_pattern_5, result)
    result = re.sub(r"\[\[(\d{4}-\d{2}-\d{2})\|(.*)\]\]", replace_pattern_6, result)
    result = re.sub(
        r"\[\[(\d{4}-\d{2}-\d{2})#(\d{2}:\d{2}:\d{2})\]\]", replace_pattern_7, result
    )
    result = re.sub(
        r"\[\[(\d{4}-\d{2}-\d{2})#(\d{2}:\d{2}:\d{2})\|(.*)\]\]",
        replace_pattern_8,
        result,
    )
    result = re.sub(
        r"\[\[\d{4}\/\d{2}\s-\s\w+\/(\d{4}-\d{2}-\d{2})\]\]", replace_pattern_9, result
    )
    result = re.sub(
        r"\[\[\d{4}\/\d{2}\s-\s\w+\/(\d{4}-\d{2}-\d{2})\|(.*)\]\]",
        replace_pattern_10,
        result,
    )
    result = re.sub(
        r"\[\[\d{4}\/\d{2}\s-\s\w+\/(\d{4}-\d{2}-\d{2})#(\d{2}:\d{2}:\d{2})\]\]",
        replace_pattern_11,
        result,
    )
    result = re.sub(
        r"\[\[\d{4}\/\d{2}\s-\s\w+\/(\d{4}-\d{2}-\d{2})#(\d{2}:\d{2}:\d{2})\|(.*)\]\]",
        replace_pattern_12,
        result,
    )

    # move linked media files.
    media_filenames: list[str] = []
    backlink_content = ""
    capturing_content = False
    i = 0
    while i < len(result):
        if result[i : i + 3] == "![[":
            capturing_content = True
            i += 3

        if capturing_content:
            if result[i : i + 2] == "]]":
                capturing_content = False
                media_filenames.append(backlink_content.partition("|")[0])
                backlink_content = ""

            else:
                backlink_content += result[i]

        i += 1

    for media_filename in media_filenames:
        if (
            media_filename not in media_files
            and media_filename not in imported_media_files
        ):
            print(
                f"WARNING: IMPORTER: NOTE: UPDATER: Cannot find media file `{media_filename}`"
            )

        else:
            media_to_move = media_files[media_filename]
            if not media_to_move.exists():
                print(
                    f"ERROR: IMPORTER: NOTE: UPDATER: The media file {media_filename} does not exist anymore."
                )
                continue

            if media_filename.lower().endswith(("jpeg", "png", "jpg", "webp", "gif")):
                shutil.move(
                    media_to_move, Path(VAULT_NEW_PATH_MEDIA, "Photos", media_filename)
                )
            elif media_filename.lower().endswith(("mp4", "mkv")):
                shutil.move(
                    media_to_move, Path(VAULT_NEW_PATH_MEDIA, "Videos", media_filename)
                )
            elif media_filename.lower().endswith(("flac", "mp3", "wav")):
                shutil.move(
                    media_to_move, Path(VAULT_NEW_PATH_MEDIA, "Audio", media_filename)
                )
            elif media_filename.lower().endswith(("md", "pdf")):
                shutil.move(
                    media_to_move,
                    Path(VAULT_NEW_PATH_MEDIA, "Documents", media_filename),
                )
            else:
                shutil.move(media_to_move, Path(VAULT_NEW_PATH_MEDIA, media_filename))

            imported_media_files.append(media_filename)
            print(f"INFO: IMPORTER: NOTE: UPDATER: Imported media `{media_filename}`")

    return result


if __name__ == "__main__":
    sys.exit(main())
