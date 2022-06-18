/* Safety Deposit Boxes
 *
 * You are robbing a bank, but you’re not taking everything.
 * You are looking for a specific item in the safety deposit
 * boxes and you are going to drill into each one in order to
 * find your item. Once you find your item you can make your
 * escape, but how long will it take you to get to that item?
 *
 * Task
 * Determine the amount of time it will take you to find the
 * item you are looking for if it takes you 5 minutes to drill
 * into each box.
 *
 * Input Format
 * A string that represent the items in each box that will be
 * drilled in order (items are separated by a comma), and
 * secondly, a string of which item you are looking for.
 *
 * Output Format
 * An integer of the amount of time it will take for you to find
 * your item.
 *
 * Sample Input
 * 'gold,diamonds,documents,Declaration of Independence,keys'
 * 'Declaration of Independence'
 *
 * Sample Output
 * 20
 */

using System;

namespace SafetyDepositBoxes
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write("Enter a list of items that will be drilled: ");
            string[] items = Console.ReadLine().Split(',');

            Console.Write("Enter the item to find: ");
            string target_item = Console.ReadLine();

            Console.WriteLine((Array.IndexOf(items, target_item) + 1) * 5);
            // A oneliner:
            // Console.WriteLine((Array.IndexOf(Console.ReadLine().Split(','), Console.ReadLine()) + 1) * 5);
            return 0;
        }
    }
}
