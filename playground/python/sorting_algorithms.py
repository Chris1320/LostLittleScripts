#!/usr/bin/env python3

"""
The Don't Ask Me About It License

Copying and distribution of this file, with or without modification, are
permitted in any medium provided you do not contact the author about the
file or any problems you are having with the file
"""

import os
import sys
import time
import random


class Settings:
    """A class to store the settings of the program."""

    def __init__(self) -> None:
        """Initializes the class."""
        self.delay: float = 1.0
        self.manual_mode: bool = False


def clrscrn() -> None:
    """Clears the contents of the screen."""
    _ = os.system("cls" if os.name == "nt" else "clear")


def pause(msg: str = "Press Enter to continue...") -> None:
    """Shows a message and waits for the user to press Enter.

    Args:
        msg: The message to show to the user.
    """

    _ = input(msg)


def delay(settings: Settings, seconds: float = 1.0) -> None:
    """Delays the execution of the program. If manual mode is enabled, the user must press Enter to continue.

    Args:
        settings: The settings of the program.
        seconds: The number of seconds to delay.
    """

    if settings.manual_mode:
        pause("")
    else:
        time.sleep(seconds)


def main() -> int:
    """The main function of the program.

    Returns:
        The exit code.
    """

    settings: Settings = Settings()
    while True:
        try:
            clrscrn()
            print("Sorting Algorithms")
            print()
            print("Configuration:")
            print(f"- Delay: {settings.delay}s")
            print(f"- Manual Mode: {'Enabled' if settings.manual_mode else 'Disabled'}")
            print()
            print("[01] Selection Sort")
            print("[02] Bubble Sort")
            print("[03] Insertion Sort")
            print("[04] Merge Sort")
            print("[05] Quick Sort")
            print()
            print("[97] Toggle Manual Mode")
            print("[98] Adjust Delay")
            print()
            print("[99] Exit")
            print()
            choice: int = int(input("Enter your choice: "))

        except ValueError:
            print("Invalid choice. Please try again.")
            pause()
            continue

        except (KeyboardInterrupt, EOFError):
            pause("\nCtrl+C/CTRL+D detected. Press enter to exit...")
            break

        try:
            match choice:
                case 1:
                    selection_sort(settings)
                case 2:
                    bubble_sort(settings)
                case 3:
                    insertion_sort(settings)
                case 4:
                    merge_sort(settings)
                case 5:
                    quick_sort(settings)
                case 97:
                    settings.manual_mode = not settings.manual_mode
                case 98:
                    settings.delay = float(
                        input(
                            f"Enter the delay in seconds (current: {settings.delay}s): "
                        )
                    )
                case 99:
                    print("Exiting...")
                    break
                case _:
                    print("Invalid choice. Please try again.")

            pause()

        except (KeyboardInterrupt, EOFError):
            pause("\nCtrl+C/CTRL+D detected. Press enter to exit...")
            break

    return 0


def fill_list(
    quanity: int,
    min_value: int = 10,
    max_value: int = 99,
) -> list[int]:
    """Fills a list with random values.

    Args:
        quanity: The number of elements to generate.
        min_value: The minimum value for the elements.
        max_value: The maximum value for the elements.

    Returns:
        A list of random integers.
    """

    return [random.randint(min_value, max_value) for _ in range(quanity)]


def selection_sort_display(
    settings: Settings,
    arr: list[int],
    i: int,
    j: int,
    min: int,
    stats: dict[str, int],
    msg: str,
    arrow_up: int = -1,
    arrow_down: int = -1,
    arrow_up_str: str = "",
    arrow_down_str: str = "",
) -> None:
    """Displays the list of elements in selection sort."""
    clrscrn()
    print("             ", " " * (arrow_up * 4), arrow_up_str if i != -1 else "")
    print("             ", " " * (arrow_up * 4), "v" if arrow_up != -1 else "")
    print(f"Iteration {f'{i + 1}'.rjust(2)}: {arr}")
    print("             ", " " * (arrow_down * 4), "^" if arrow_down != -1 else "")
    print(
        "             ",
        " " * (arrow_down * 4),
        arrow_down_str if arrow_down != -1 else "",
    )
    print()
    print(msg)
    print(f"Sorted (i)    : {i}")
    print(f"Head (j)      : {j}")
    print(f"Minimum (m)   : {min}")
    print(f"Comparisons   : {stats['comparisons']}")
    print(f"Swaps         : {stats['swaps']}")
    delay(settings)


def selection_sort(settings: Settings) -> None:
    """Selection sort algorithm."""
    print("Selection Sort")
    print()
    arr: list[int] = fill_list(10)  # Generate a list of random integers
    old_arr: list[int] = arr.copy()  # Copy the list for comparison
    stats: dict[str, int] = {"comparisons": 0, "swaps": 0}  # Stats for the algorithm

    selection_sort_display(
        settings,
        arr,
        -1,
        -1,
        -1,
        stats,
        "Starting the selection sort algorithm",
    )

    # Selection sort algorithm
    for i in range(len(arr)):  # For each element in the list
        min_idx: int = i  # Assume the current element is the smallest

        for j in range(i + 1, len(arr)):  # Check the rest of the list
            stats["comparisons"] += 1  # Increment the number of comparisons
            selection_sort_display(
                settings,
                arr,
                i,
                j,
                min_idx,
                stats,
                f"Comparing {arr[j]} (idx {j}) with {arr[min_idx]} (idx {min_idx})",
                min_idx,
                j,
                "m",
                "j",
            )
            if arr[j] < arr[min_idx]:  # If the current element is smaller
                min_idx = j  # Update the index of the smallest element

        if min_idx != i:
            arr[i], arr[min_idx] = arr[min_idx], arr[i]  # Swap the elements
            stats["swaps"] += 1  # Increment the number of swaps
            selection_sort_display(
                settings,
                arr,
                i,
                -1,
                min_idx,
                stats,
                f"Swapped {arr[i]} (idx {i}) with {arr[min_idx]} (idx {min_idx})",
                i,
                min_idx,
                "i",
                "m",
            )

    print("=" * 40)
    print("Original vs Sorted List:")
    print(old_arr)
    print(arr)


def bubble_sort_display(
    settings: Settings,
    arr: list[int],
    i: int,
    j: int,
    sorted: int,
    stats: dict[str, int],
    msg: str,
    arrow_up: int = -1,
    arrow_down: int = -1,
    arrow_up_str: str = "",
    arrow_down_str: str = "",
) -> None:
    """Displays the list of elements in bubble sort."""
    clrscrn()
    print("             ", " " * (arrow_up * 4), arrow_up_str if i != -1 else "")
    print("             ", " " * (arrow_up * 4), "v" if arrow_up != -1 else "")
    print(f"Iteration {f'{i + 1}'.rjust(2)}: {arr}")
    print("             ", " " * (arrow_down * 4), "^" if arrow_down != -1 else "")
    print(
        "             ",
        " " * (arrow_down * 4),
        arrow_down_str if arrow_down != -1 else "",
    )
    print()
    print(msg)
    print(f"Head (i)      : {i}")
    print(f"Tail (j)      : {j}")
    print(f"Sorted (s)    : {sorted}")
    print(f"Comparisons   : {stats['comparisons']}")
    print(f"Swaps         : {stats['swaps']}")
    delay(settings)


def bubble_sort(settings: Settings) -> None:
    """Bubble sort algorithm."""
    print("Bubble Sort")
    print()
    arr: list[int] = fill_list(10)  # Generate a list of random integers
    old_arr: list[int] = arr.copy()  # Copy the list for comparison
    stats: dict[str, int] = {"comparisons": 0, "swaps": 0}  # Stats for the algorithm
    sorted_idx: int = len(arr)  # The index of the sorted elements

    bubble_sort_display(
        settings,
        arr,
        -1,
        -1,
        sorted_idx,
        stats,
        "Starting the bubble sort algorithm",
    )

    # Bubble sort algorithm
    for i in range(len(arr)):  # For each element in the list
        for j in range(len(arr) - i - 1):
            stats["comparisons"] += 1
            bubble_sort_display(
                settings,
                arr,
                i,
                j,
                sorted_idx,
                stats,
                f"Comparing {arr[j]} (idx {j}) with {arr[j + 1]} (idx {j + 1})",
                j,
                j + 1,
                "j",
                "j+1",
            )

            if arr[j] > arr[j + 1]:  # If the current element is larger
                arr[j], arr[j + 1] = arr[j + 1], arr[j]
                stats["swaps"] += 1
                bubble_sort_display(
                    settings,
                    arr,
                    i,
                    j,
                    sorted_idx,
                    stats,
                    f"Swapped {arr[j]} (idx {j}) with {arr[j + 1]} (idx {j + 1})",
                    j,
                    j + 1,
                    "j",
                    "j+1",
                )

        sorted_idx -= 1

    print("=" * 40)
    print("Original vs Sorted List:")
    print(old_arr)
    print(arr)


def insertion_sort_display(
    settings: Settings,
    arr: list[int],
    i: int,
    j: int,
    key: int,
    stats: dict[str, int],
    msg: str,
    arrow_up: int = -1,
    arrow_down: int = -1,
    arrow_up_str: str = "",
    arrow_down_str: str = "",
) -> None:
    """Displays the list of elements in insertion sort."""
    clrscrn()
    print("             ", " " * (arrow_up * 4), arrow_up_str if i != -1 else "")
    print("             ", " " * (arrow_up * 4), "v" if arrow_up != -1 else "")
    print(f"Iteration {f'{i + 1}'.rjust(2)}: {arr}")
    print("             ", " " * (arrow_down * 4), "^" if arrow_down != -1 else "")
    print(
        "             ",
        " " * (arrow_down * 4),
        arrow_down_str if arrow_down != -1 else "",
    )
    print()
    print(msg)
    print(f"Key (i)       : {i}")
    print(f"Tail (j)      : {j}")
    print(f"Key Value     : {key}")
    print(f"Comparisons   : {stats['comparisons']}")
    print(f"Insertions    : {stats['insertions']}")
    delay(settings)


def insertion_sort(settings: Settings) -> None:
    """Insertion sort algorithm."""
    print("Insertion Sort")
    print()
    arr: list[int] = fill_list(10)  # Generate a list of random integers
    old_arr: list[int] = arr.copy()  # Copy the list for comparison
    stats: dict[str, int] = {
        "comparisons": 0,
        "insertions": 0,
    }  # Stats for the algorithm

    insertion_sort_display(
        settings,
        arr,
        -1,
        -1,
        -1,
        stats,
        "Starting the insertion sort algorithm",
    )

    # Insertion sort algorithm
    for i in range(1, len(arr)):  # For each element in the list
        key: int = arr[i]
        j: int = i - 1

        while j >= 0 and key < arr[j]:
            stats["comparisons"] += 1
            insertion_sort_display(
                settings,
                arr,
                i,
                j,
                key,
                stats,
                f"Comparing {key} (idx {i}) with {arr[j]} (idx {j})",
                i,
                j,
                "i",
                "j",
            )
            arr[j + 1] = arr[j]
            j -= 1

        arr[j + 1] = key
        stats["insertions"] += 1
        insertion_sort_display(
            settings,
            arr,
            i,
            j,
            key,
            stats,
            f"Inserted {key} (idx {i}) into index {j + 1} (j+1)",
            i,
            j + 1,
            "i",
            "j+1",
        )

    print("=" * 40)
    print("Original vs Sorted List:")
    print(old_arr)
    print(arr)


def merge_sort_display(
    settings: Settings,
    arr: list[int],
    left: list[int],
    right: list[int],
    stats: dict[str, int],
) -> None:
    """Displays the list of elements in merge sort."""

    # HELP I DON'T KNOW HOW TO VISUALIZE THIS THING
    clrscrn()
    print(f"Array         : {arr}")
    print()
    print(f"Left (l)      : {left}")
    print(f"Right (r)     : {right}")
    print(f"Divisions     : {stats['divisions']}")
    print(f"Merges        : {stats['merges']}")
    delay(settings)


def merge_sort(settings: Settings) -> None:
    """Merge sort algorithm."""
    print("Merge Sort")
    print()
    arr: list[int] = fill_list(10)  # Generate a list of random integers
    old_arr: list[int] = arr.copy()  # Copy the list for comparison
    stats: dict[str, int] = {
        "divisions": 0,
        "merges": 0,
    }  # Stats for the algorithm

    merge_sort_display(
        settings,
        arr,
        [],
        [],
        stats,
    )

    # Merge sort algorithm
    # Use a recursive function to split the list into smaller lists.
    def merge_sort_recursive(arr: list[int], left: int, right: int) -> None:
        """Recursively splits the list into smaller lists."""
        if left < right:
            mid: int = (left + right) // 2  # Find the middle of the list
            stats["divisions"] += 1
            merge_sort_display(
                settings,
                arr,
                arr[left : mid + 1],
                arr[mid + 1 : right + 1],
                stats,
            )
            merge_sort_recursive(arr, left, mid)  # Split the left side
            merge_sort_recursive(arr, mid + 1, right)  # Split the right side
            merge_sort_merge(arr, left, mid, right)  # Merge the smaller lists

    def merge_sort_merge(arr: list[int], left: int, mid: int, right: int) -> None:
        """Merges the smaller lists back together."""
        n1: int = mid - left + 1  # Length of the left list
        n2: int = right - mid  # Length of the right list

        left_list: list[int] = [0] * n1  # Create a list for the left side
        right_list: list[int] = [0] * n2  # Create a list for the right side

        for i in range(n1):
            left_list[i] = arr[left + i]  # Copy the left side

        for j in range(n2):
            right_list[j] = arr[mid + 1 + j]  # Copy the right side

        i = j = 0  # Index for the left and right lists
        k = left  # Index for the main list

        while i < n1 and j < n2:  # Merge the lists
            if left_list[i] <= right_list[j]:
                arr[k] = left_list[i]
                i += 1
            else:
                arr[k] = right_list[j]
                j += 1

            k += 1

        while i < n1:  # Copy the remaining elements of the left list
            arr[k] = left_list[i]
            i += 1
            k += 1

        while j < n2:  # Copy the remaining elements of the right list
            arr[k] = right_list[j]
            j += 1
            k += 1

        stats["merges"] += 1
        merge_sort_display(
            settings,
            arr,
            left_list,
            right_list,
            stats,
        )

    merge_sort_recursive(arr, 0, len(arr) - 1)

    print("=" * 40)
    print("Original vs Sorted List:")
    print(old_arr)
    print(arr)


def quick_sort_display(
    settings: Settings,
    arr: list[int],
    p: int,
    stats: dict[str, int],
    msg: str,
) -> None:
    """Displays the list of elements in quick sort."""
    # i give up visualizing this thing
    clrscrn()
    print(f"Array         : {arr}")
    print()
    print(msg)
    print()
    print(f"Pivot (p)     : {p}")
    print(f"Comparisons   : {stats['comparisons']}")
    print(f"Swaps         : {stats['swaps']}")
    delay(settings)


def quick_sort(settings: Settings) -> None:
    """Quick sort algorithm."""
    print("Quick Sort")
    print()
    arr: list[int] = fill_list(10)  # Generate a list of random integers
    old_arr: list[int] = arr.copy()  # Copy the list for comparison
    stats: dict[str, int] = {
        "comparisons": 0,
        "swaps": 0,
    }  # Stats for the algorithm

    quick_sort_display(
        settings,
        arr,
        -1,
        stats,
        "Starting the quick sort algorithm",
    )

    # Quick sort algorithm
    def quick_sort_recursive(arr: list[int], low: int, high: int) -> None:
        """Recursively sorts the list."""
        if low < high:
            p: int = quick_sort_partition(arr, low, high)
            quick_sort_display(
                settings,
                arr,
                p,
                stats,
                f"Partitioned the list at index {p}",
            )
            quick_sort_recursive(arr, low, p - 1)
            quick_sort_recursive(arr, p + 1, high)

    def quick_sort_partition(arr: list[int], low: int, high: int) -> int:
        """Partitions the list."""
        i: int = low - 1
        pivot: int = arr[high]

        for j in range(low, high):
            stats["comparisons"] += 1
            quick_sort_display(
                settings,
                arr,
                pivot,
                stats,
                f"Comparing {arr[j]} (idx {j}) with {pivot}",
            )
            if arr[j] < pivot:
                i += 1
                arr[i], arr[j] = arr[j], arr[i]
                stats["swaps"] += 1
                quick_sort_display(
                    settings,
                    arr,
                    pivot,
                    stats,
                    f"Swapped {arr[i]} (idx {i}) with {arr[j]} (idx {j})",
                )

        arr[i + 1], arr[high] = arr[high], arr[i + 1]
        stats["swaps"] += 1
        quick_sort_display(
            settings,
            arr,
            pivot,
            stats,
            f"Swapped {arr[i + 1]} (idx {i+1}) with {arr[high]} (idx {high})",
        )

        return i + 1

    quick_sort_recursive(arr, 0, len(arr) - 1)

    print("=" * 40)
    print("Original vs Sorted List:")
    print(old_arr)
    print(arr)


if __name__ == "__main__":
    sys.exit(main())
