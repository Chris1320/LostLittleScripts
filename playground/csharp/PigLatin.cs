/*
 * Pig Latin
 *
 * You have two friends who are speaking Pig Latin to each other!
 * Pig Latin is the same words in the same order except that you
 * take the first letter of each word and put it on the end, then
 * you add 'ay' to the end of that. ("road" = "oadray")
 *
 * Task
 * Your task is to take a sentence in English and turn it into the
 * same sentence in Pig Latin!
 *
 * Input Format
 * A string of the sentence in English that you need to translate
 * into Pig Latin. (no punctuation or capitalization)
 *
 * Output Format
 * A string of the same sentence in Pig Latin.
 *
 * Sample Input
 * "nevermind youve got them"
 *
 * Sample Output
 * "evermindnay ouveyay otgay hemtay"
 */

using System;

namespace PigLatin
{
    class PigLatin
    {
        static int Main(string[] args)
        {
            string original_text;
            string[] text_array;
            string result = "";

            if (args.Length != 0)  // Check if there arguments present.
            {
                original_text = string.Join(' ', args);
            }
            else
            {
                Console.Write("Enter the phrase to convert: ");
                original_text = Console.ReadLine();
            }

            text_array = original_text.Split(' ');  // Divide string.
            foreach (var word in text_array)
            {
                var first_char = word[0];
                var split_word = word.Remove(0, 1); // Remove characters starting from index 0 with length of 1.
                split_word += (first_char + "ay");
                result += (split_word + ' ');
            }

            Console.WriteLine(result);
            return 0;
        }
    }
}
