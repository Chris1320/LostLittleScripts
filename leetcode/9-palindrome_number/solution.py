class Solution:
    def __call__(self) -> None:
        test_cases: list[int] = [121, -121, 10]
        for test in test_cases:
            print(f"Test Input: {test}\nResult: {self.isPalindrome(test)}\n")

    def isPalindrome(self, x: int) -> bool:
        return str(x) == str(x)[::-1]


if __name__ == "__main__":
    Solution()()

