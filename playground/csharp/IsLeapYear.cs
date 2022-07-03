/*
 * An extra day is added to the calendar almost every four years as February 29,
 * and the day is called a leap day. It corrects the calendar for the fact that
 * our planet takes approximately 365.25 days to orbit the sun. A leap year
 * contains a leap day.
 *
 * In the Gregorian calendar, three conditions are used to identify leap years:
 *
 * - The year can be evenly divided by 4, is a leap year, unless:
 *     - The year can be evenly divided by 100, it is NOT a leap year, unless:
 *         - The year is also evenly divisible by 400. Then it is a leap year.
 *
 * This means that in the Gregorian calendar, the years 2000 and 2400 are leap
 * years, while 1800, 1900, 2100, 2200, 2300 and 2500 are NOT leap years.
 *
 * Task:
 * Given a year, determine whether it is a leap year. If it is a leap year,
 * return the Boolean True, otherwise return False.
 *
 * Note that the code stub provided reads from STDIN and passes arguments to the
 * is_leap function. It is only necessary to complete the is_leap function.
 *
 * Input Format:
 * Read `year`, the year to test.
 *
 * Constraints:
 * 1900 <= year <= 10^5
 *
 * Output Format:
 * The function must return a Boolean value (True/False). Output is handled by
 * the provided code stub.
 *
 * Sample Input 0:
 * 1990
 *
 * Sample Output 0:
 * False
 *
 * Explanation 0:
 * 1990 is not a multiple of 4 hence it's not a leap year.
 */

using System;

namespace IsLeapYear
{
    class Program
    {
        static bool isLeap(int year)
        {
            // A year is leap if either of the following conditions are met:
            // - The year is divisible by 400; or
            // - The year is divisible by 4 but not divisible by 100.
            if (year % 400 == 0 || (year % 4 == 0 && !(year % 100 == 0))) return true;
            else return false;
        }
        static int Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (isLeap(year)) Console.WriteLine("{0} is a leap year.", year);
            else Console.WriteLine("{0} is not a leap year.", year);

            return 0;
        }
    }
}
