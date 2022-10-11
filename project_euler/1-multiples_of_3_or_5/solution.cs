/*
 * Problem 1: Multiples of 3 or 5
 *
 * If we list all the natural numbers below 10 that are
 * multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of
 * these multiples is 23.
 *
 * Find the sum of all the multiples of 3 or 5 below 1000.
 *
 * https://projecteuler.net/problem=1
 */

using System;

namespace Multiples_of_3_or_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)  // ? Is there a better algorithm to use than
            {                               // ? looping from 0 to 1,000?
                if (i % 3 == 0 || i % 5 == 0)  // Check if i is a multiple of 3 or 5.
                {
                    sum += i;  // Add to the sum.
                }
            }
            Console.WriteLine(sum);  // Print the sum.
        }
    }
}
