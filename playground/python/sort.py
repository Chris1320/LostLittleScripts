def rearrange_negative_positive(arr: list[int]):
    l = 0
    r = len(arr) - 1

    while l <= r:
        if arr[l] < 0: l += 1  # negative
        elif arr[r] >= 0: r -= 1  # positive
        else:
            arr[l], arr[r] = arr[r], arr[l]
            l += 1
            r -= 1


def main():
    tests = [
        [1, 2, 3, 4, 5, 6],           # Output: [1, 2, 3, 4, 5, 6]
        [-1, -2, -3, -4, -5, -6],     # Output: [-1, -2, -3, -4, -5, -6]
        [-1, 2, -3, 4, -5, 6],        # Output: [-1, -5, -3, 4, 2, 6]
        [1, -2, 3, -4, 5, -6, 7, -8], # Output: [-8, -2, -6, -4, 5, 3, 7, 1]
    ]
    for test in tests:
        rearrange_negative_positive(test)
        print(test)


if __name__ == "__main__":
    main()