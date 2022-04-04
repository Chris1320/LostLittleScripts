/*
 * Deja Vu
 *
 * You aren't paying attention and you accidentally type a bunch of random letters
 * on your keyboard. You want to know if you ever typed the same letter twice, or
 * if they are all unique letters.
 *
 * Task:
 * If you are given a string of random letters, your task is to evaluate whether
 * any letter is repeated in the string or if you only hit unique keys while you are
 * typing.
 *
 * Input Format:
 * A string of random letter characters (no numbers or other buttons were pressed)
 *
 * Output Format:
 * A string that says 'Deja Vu' if any letter is repeated in the input string,
 * or a string that says 'Unique' if there are no repeats.
 *
 * Sample Input:
 * aaaaaaaghhhhjkll
 *
 * Sample Output:
 * Deja Vu
 */

using System;

namespace DejaVu
{
    class Program
    {
        static int Main(string[] args)
        {
            int i, c;  // Temporary variables
            bool unique = true;
            int chars_selector = 0;  // Array index selector

            string words = Console.ReadLine();  // Read user input
            char[] chars = new char[words.Length];  // Create an array with the size of <words.Length>.

            for (i = 0; i < words.Length; i++)  // Loop through the characters of <words>.
            {
                if (chars_selector == 0)  // Check if this is the first character to evaluate.
                {
                    /* If it is,
                     *     1. Add the character to <chars> array
                     *     2. Increment <chars_selector>.
                     *     3. Continue the loop.
                     */
                    chars[chars_selector] = words[i];
                    chars_selector++;
                    continue;
                }
                else  // Otherwise, continue the evaluation.
                {
                    for (c = 0; c < chars_selector; c++)  // Check every element in the array.
                    {
                        if (words[i] == chars[c])  // Evaluate
                        {
                            Console.WriteLine("Deja Vu");
                            unique = false;
                            break;
                        }
                    }
                    chars[chars_selector] = words[i];
                    chars_selector++;
                }
                if (!unique) break;  // If unique is now false, break the loop.
            }
            if (unique) Console.WriteLine("Unique");

            return 0;
        }
    }
}