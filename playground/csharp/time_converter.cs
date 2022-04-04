/*
 * Time Converter
 *
 * You need a program to convert days to seconds.
 * The given code takes the amount of days as input.
 * Complete the code to convert it to seconds and output the result.
 *
 * Sample Input:
 * 12
 *
 * Sample Output:
 * 1036800
 */

using System;

namespace TimeConverter
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write("Enter number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(days * (24 * 3600));

            return 0;
        }
    }
}
