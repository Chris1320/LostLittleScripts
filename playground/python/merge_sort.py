def merge_sort(arr: list[str]) -> list[str]:
    if len(arr) <= 1:
        return arr

    mid = len(arr) // 2
    left_half = arr[:mid]
    right_half = arr[mid:]

    print(left_half, right_half)

    left_half = merge_sort(left_half)
    right_half = merge_sort(right_half)

    return merge(left_half, right_half)


def merge(left: list[str], right: list[str]) -> list[str]:
    merged: list[str] = []
    left_index, right_index = 0, 0

    while left_index < len(left) and right_index < len(right):
        if left[left_index] < right[right_index]:
            merged.append(left[left_index])
            left_index += 1
        else:
            merged.append(right[right_index])
            right_index += 1

    merged.extend(left[left_index:])
    merged.extend(right[right_index:])
    return merged


def main() -> None:
    my_list: list[str] = ["E", "X", "A", "M", "P", "L", "E"]
    print(my_list)
    sorted_list: list[str] = merge_sort(my_list)
    print(sorted_list)


if __name__ == "__main__":
    main()
