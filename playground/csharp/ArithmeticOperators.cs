/*
 * Arithmetic Operators
 *
 * The provided code stub reads two integers from STDIN, a and b.
 * Add code to print three lines where:
 *
 *     1. The first line contains the sum of the two numbers.
 *     2. The second line contains the difference of the two numbers (first - second).
 *     3. The third line contains the product of the two numbers.
 *
 * Example:
 *     a = 3
 *     b = 5
 *
 * Print the Following:
 *     8
 *     -2
 *     15
 *
 * Input Format:
 *     The first line contains the first integer, a.
 *     The second line contains the second integer, b.
 *
 * Constraints:
 *     1 <= a <= 10^10
 *     1 <= b <= 10^10
 *
 * Output Format:
 *     Print the three lines as explained above.
 *
 * Sample Input 0:
 *     3
 *     2
 *
 * Sample Output 0:
 *     5
 *     1
 *     6
 *
 * Explanation 0:
 *     3 + 2 --> 5
 *     3 - 2 --> 1
 *     3 * 2 --> 6
 */

using System;

namespace ArithmeticOperators
{
    class Program
    {
        public static int Main(string[] args)
        {
            int a, b;

            Console.Write("Enter num 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num 2: ");
            b = Convert.ToInt32(Console.ReadLine());

            // Print results
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);

            return 0;
        }
    }
}
