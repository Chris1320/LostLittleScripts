import argparse
import csv
import sys

import prettytable
from colorama import Fore as col_f
from colorama import Style as col_s


def ms_students(student_records: list[tuple[str, float]]) -> list[tuple[str, float]]:
    """Sort the list of student records by grade using merge sort."""

    if len(student_records) <= 1:
        return student_records

    mid: int = len(student_records) // 2
    left_half: list[tuple[str, float]] = student_records[:mid]
    right_half: list[tuple[str, float]] = student_records[mid:]

    new_left_half: list[tuple[str, float]] = ms_students(left_half)
    new_right_half: list[tuple[str, float]] = ms_students(right_half)

    return m_students(new_left_half, new_right_half)


def m_students(
    left: list[tuple[str, float]], right: list[tuple[str, float]]
) -> list[tuple[str, float]]:
    """Merge two sorted lists of student records."""

    m: list[tuple[str, float]] = []
    l_idx = r_idx = 0

    while l_idx < len(left) and r_idx < len(right):
        if left[l_idx][1] < right[r_idx][1]:  # Compare grades
            m.append(left[l_idx])
            l_idx += 1

        else:
            m.append(right[r_idx])
            r_idx += 1

    m.extend(left[l_idx:])
    m.extend(right[r_idx:])
    return m


def main() -> int:
    arg_parser = argparse.ArgumentParser()
    _ = arg_parser.add_argument(
        "student_scores",
        type=str,
        help="The CSV file containing student records.",
    )
    args = arg_parser.parse_args()

    students: list[tuple[str, float]] = []
    print("Reading student records from file...")
    with open(args.student_scores) as file:  # pyright: ignore [reportAny]
        reader = csv.reader(file)
        for row in reader:
            students.append((row[0], float(row[1])))

    unordered_table = prettytable.PrettyTable(
        ["Student Name", "Grade"], title="Unsorted Student Records"
    )
    for s in students[::-1]:
        match s[1]:
            case _ if s[1] < 60:
                unordered_table.add_row([s[0], f"{col_f.RED}{s[1]}{col_s.RESET_ALL}"])

            case _ if s[1] < 80:
                unordered_table.add_row(
                    [s[0], f"{col_f.YELLOW}{s[1]}{col_s.RESET_ALL}"]
                )

            case _:
                unordered_table.add_row([s[0], f"{col_f.GREEN}{s[1]}{col_s.RESET_ALL}"])

    print("Sorting student records...")
    sorted_students: list[tuple[str, float]] = ms_students(students)
    ordered_table: prettytable.PrettyTable = prettytable.PrettyTable(
        ["Student Name", "Grade"], title="Sorted Student Records"
    )
    for s in sorted_students[::-1]:
        match s[1]:
            case _ if s[1] < 60:
                ordered_table.add_row([s[0], f"{col_f.RED}{s[1]}{col_s.RESET_ALL}"])

            case _ if s[1] < 80:
                ordered_table.add_row([s[0], f"{col_f.YELLOW}{s[1]}{col_s.RESET_ALL}"])

            case _:
                ordered_table.add_row([s[0], f"{col_f.GREEN}{s[1]}{col_s.RESET_ALL}"])

    unsorted_table_str: list[str] = (
        unordered_table.get_string().splitlines()  # pyright: ignore [reportUnknownMemberType]
    )
    sorted_table_str: list[str] = (
        ordered_table.get_string().splitlines()  # pyright: ignore [reportUnknownMemberType]
    )

    for i in range(max(len(unsorted_table_str), len(sorted_table_str))):
        if i < len(unsorted_table_str):
            print(unsorted_table_str[i], end="")

        if i < len(sorted_table_str):
            print(" " * 10, end="")
            print(sorted_table_str[i], end="")

        print()

    return 0


if __name__ == "__main__":
    sys.exit(main())
