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

#include <stdio.h>
#include <string.h>  // For using strlen() function.
#include <stdbool.h>  // For using a boolean datatype.

int main() {
    int _, c;  // Temporary variables
    char string[50];  // Declare a string of length 50.
    char chars[40] = {};  // Declare an empty array of characters.
    int num_of_chars = 0;  // chars[] selector
    bool unique = true;

    scanf("%50s", string);  // Get user input.
    for (_ = 0; _ < strlen(string); _++)  // Loop through the string.
    {
        if (!unique) break;  // Break if "Deja Vu" is already printed.
        if (!(num_of_chars == 0))  // If this is the first char, add it to chars[].
        {
            for (c = 0; c < (num_of_chars); c++)  // Loop through chars[]
            {
                if (chars[c] == string[_])  // Check if string[_] in chars[].
                {
                    printf("Deja Vu\n");  // Print "Deja Vu" and break loop.
                    unique = false;
                    break;
                }
            }
        }
        chars[num_of_chars] = string[_];  // Add string[_] to chars[].
        num_of_chars++;  // Increment variable.
    }
    if (unique) printf("Unique\n");  // Print if unique.

    return 0;
}
