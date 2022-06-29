"""
An extra day is added to the calendar almost every four years as February 29,
and the day is called a leap day. It corrects the calendar for the fact that
our planet takes approximately 365.25 days to orbit the sun. A leap year
contains a leap day.

In the Gregorian calendar, three conditions are used to identify leap years:

- The year can be evenly divided by 4, is a leap year, unless:
    - The year can be evenly divided by 100, it is NOT a leap year, unless:
        - The year is also evenly divisible by 400. Then it is a leap year.

This means that in the Gregorian calendar, the years 2000 and 2400 are leap
years, while 1800, 1900, 2100, 2200, 2300 and 2500 are NOT leap years.

Task:
Given a year, determine whether it is a leap year. If it is a leap year,
return the Boolean True, otherwise return False.

Note that the code stub provided reads from STDIN and passes arguments to the
is_leap function. It is only necessary to complete the is_leap function.

Input Format:
Read `year`, the year to test.

Constraints:
1900 <= year <= 10^5

Output Format:
The function must return a Boolean value (True/False). Output is handled by
the provided code stub.

Sample Input 0:
1990

Sample Output 0:
False

Explanation 0:
1990 is not a multiple of 4 hence it's not a leap year.
"""


def is_leap(year) -> bool:
    # A year is leap if either of the following conditions are met:
    # - The year is divisible by 400; or
    # - The year is divisible by 4 but not divisible by 100.
    if (year % 400 == 0) or (year % 4 == 0 and not (year % 100 == 0)):
        return True

    else:
        return False

    # One-liner:
    # return True if (year % 400 == 0) or (year % 4 == 0 and not (year % 100 == 0)) else False


year = int(input("Enter a year: "))
if is_leap(year):
    print(f"{year} is a leap year.")

else:
    print(f"{year} is not a leap year.")
