import os
import sys
from typing import Final

DEFAULT_IDS: Final[str] = "ids.txt"
DEFAULT_NAMES: Final[str] = "names.txt"


def load_employee_list(
    ids: str = DEFAULT_IDS, names: str = DEFAULT_NAMES
) -> tuple[list[int], list[str]]:
    """load the data from the files"""

    with open(ids) as f:
        id_data = list(map(int, f.read().splitlines()))

    with open(names) as f:
        name_data = f.read().splitlines()

    return (id_data, name_data)


def save_employee_list(
    id_data: list[int],
    name_data: list[str],
    ids: str = DEFAULT_IDS,
    names: str = DEFAULT_NAMES,
) -> None:
    """save the data to the files"""
    with open(ids, "w") as f:
        _ = f.write("\n".join(map(str, id_data)))

    with open(names, "w") as f:
        _ = f.write("\n".join(name_data))


def search_employee_list(names: list[int], name: int) -> tuple[int, int]:
    """use binary search to find the name in the index in the sorted list"""

    lookups = 1
    low = 0
    high = len(names) - 1

    while low <= high:
        # print("low:", low, "high:", high)
        mid = (low + high) // 2

        if names[mid] == name:
            return mid, lookups

        if names[mid] < name:
            low = mid + 1

        else:
            high = mid - 1

        lookups += 1

    return -1, lookups


def main() -> int:
    if not os.path.exists(DEFAULT_IDS) or not os.path.exists(DEFAULT_NAMES):
        # create empty files if they don't exist
        with open(DEFAULT_IDS, "w") as _:
            pass

        with open(DEFAULT_NAMES, "w") as _:
            pass

    employee_ids, names = load_employee_list()

    while True:
        print("Company Employee List")
        print("---------")
        print("Total employees:", len(employee_ids))
        print()
        print("[A] Add employee")
        print("[S] Search employee")
        print("[E] Exit")
        print()

        choice: str = input("Enter choice: ").upper()

        if choice == "A":
            try:
                employee_id = int(input("Enter ID: "))
                name = input("Enter name: ")

                index = search_employee_list(list(map(int, employee_ids)), employee_id)[
                    0
                ]

                if index != -1:
                    print("Employee already exists")
                    print("ID:", employee_ids[index])
                    print("Name:", names[index])
                    print()
                    continue

                employee_ids.append(employee_id)
                names.append(name)

                employee_ids.sort()
                save_employee_list(employee_ids, names)

            except Exception as e:
                print("An error occurred:", e)

        elif choice == "S":
            try:
                name = int(input("Enter ID: "))

                index, lookups = search_employee_list(employee_ids, name)

                if index == -1:
                    print("Employee not found")
                    print()
                    continue

                print("ID:", employee_ids[index])
                print("Name:", names[index])

                print("Lookups:", lookups)

            except Exception as e:
                print("An error occurred:", e)

        elif choice == "E":
            break

        else:
            print("Invalid choice")

    return 0


if __name__ == "__main__":
    sys.exit(main())
