def sort_it(a: list[int]):
    l, r = 0, len(a) - 1

    while l <= r:
        if a[l] < 0: l += 1
        elif a[r] >= 0: r -= 1
        else:
            a[l], a[r] = a[r], a[l]
            l += 1
            r -= 1

    return a


def main():
    for test in [
        [1, 2, 3, 4, 5, 6],           # Output: [ 1,  2,  3,  4,  5,  6]
        [-1, -2, -3, -4, -5, -6],     # Output: [-1, -2, -3, -4, -5, -6]
        [-1, 2, -3, 4, -5, 6],        # Output: [-1, -5, -3,  4,  2,  6]
        [1, -2, 3, -4, 5, -6, 7, -8], # Output: [-8, -2, -6, -4,  5,  3, 7, 1]
    ]:
        print(sort_it(test))


if __name__ == "__main__":
    main()
