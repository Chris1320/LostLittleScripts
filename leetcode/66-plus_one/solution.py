class Solution:
    def __call__(self):
        test_cases = [
            [[1, 2, 3], [1, 2, 4]],
            [[4, 3, 2, 1], [4, 3, 2, 2]],
            [[9], [1, 0]],
        ]
        for test_case in test_cases:
            result = self.plusOne(test_case[0].copy())
            print(f"{test_case[0]} == {result} (expected {test_case[1]})")

    def plusOne(self, digits: list[int]) -> list[int]:
        i = len(digits) - 1
        digits[i] += 1
        while i >= 0:
            if digits[i] > 9:
                digits[i] = 0
                if i - 1 == -1:
                    digits.insert(0, 1)
                else:
                    digits[i - 1] += 1

            i -= 1

        return digits


if __name__ == "__main__":
    Solution()()
