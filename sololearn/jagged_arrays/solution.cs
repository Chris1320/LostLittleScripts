/*
 * Jagged Arrays
 *
 * The qualifiers for the Olympiad lasts 3 days,
 * and one winner is selected each qualifying day.
 *
 * The jagged array you are given represents the
 * list of all participants, divided by the number
 * of days (there are 3 arrays inside the main one,
 * each representing the participants who took part
 * on that day).
 *
 * string[][] olympiad = new string[][] {
 *     //day 1 => 5 participants
 *     new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
 *     //day 2 => 7 participants
 *     new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
 *     //day 3 => 4 participants
 *     new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana",}
 * };
 *
 * Write a program to take the numbers of each day's
 * winners as input and output them.
 *
 * Sample Input
 * 2
 * 3
 * 4
 *
 * Sample Output
 * Bridgette Ramona
 * Fran Mayur
 * Kristian Dana
 *
 * Explanation
 * Day 1 winner is Bridgette Ramona (the 2nd participant of day 1)
 * Day 2 winner is Fran Mayur (the 3rd participant of day 2)
 * Day 3 winner is Kristian Dana (the 4th participant of day 3)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int day1Winner = Convert.ToInt32(Console.ReadLine());
            int day2Winner = Convert.ToInt32(Console.ReadLine());
            int day3Winner = Convert.ToInt32(Console.ReadLine());

            string[][] olympiad = new string[][]
            {
                // day 1 - 5 participants
                new string[] {
                    "Jill Yan",
                    "Bridgette Ramona",
                    "Sree Sanda",
                    "Jareth Charlene",
                    "Carl Soner"
                },
                // day 2 - 7 participants
                new string[] {
                    "Anna Hel",
                    "Mariette Vedrana",
                    "Fran Mayur",
                    "Drake Hilmar",
                    "Nikolay Brooks",
                    "Eliana Vlatko",
                    "Villem Mario"
                },
                // day 3 - 4 participants
                new string[] {
                    "Hieremias Zavia",
                    "Ziya Ollie",
                    "Christoffel Casper",
                    "Kristian Dana"
                }
            };
            // your code goes here
            Console.WriteLine(olympiad[0][day1Winner - 1]);
            Console.WriteLine(olympiad[1][day2Winner - 1]);
            Console.WriteLine(olympiad[2][day3Winner - 1]);
        }
    }
}
