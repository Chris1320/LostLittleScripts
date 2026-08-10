def main(nums: list[int], target: int) -> list[int]:
    head = 0
    while head < len(nums):
        tail = head + 1
        while tail < len(nums):
            if nums[head] + nums[tail] == target:
                return [head, tail]
            tail += 1
        head += 1
    return []


if __name__ == "__main__":
    test_cases = [
        {"nums": [2, 7, 11, 15], "target": 9, "expected": [0, 1]},
        {"nums": [3, 2, 4], "target": 6, "expected": [1, 2]},
        {"nums": [3, 3], "target": 6, "expected": [0, 1]},
    ]
    for test_case in test_cases:
        print(
            "{result} (expected: {expected})".format(
                result=main(
                    test_case["nums"],  # pyright: ignore[reportArgumentType]
                    test_case["target"],  # pyright: ignore[reportArgumentType]
                ),
                expected=test_case["expected"],
            )
        )
