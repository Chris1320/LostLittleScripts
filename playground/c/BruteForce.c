/*
 * Brute Force Example
 *
 * This program asks the user for a string and it will
 * perform a brute force search until the new string
 * matches the string the user entered.
 */

#include <stdio.h>
#include <string.h>

#define ALPHABET "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
#define MAX_ITERATIONS 1000000

/**
 * This function will ask the user for a word.
 */
void getUserInput(char *word)
{
    printf("Enter your word: ");
    scanf("%s", word);
}

/**
 * This function will perform a brute force search
 * until the string matches the string the user entered.
 */
int performBruteForce(char *word)
{
    char new_word[100] = {0};
    int i = 0, j = 0, c = 0;

    while (1)
    {
        if (c == MAX_ITERATIONS)
        {
            printf("The word %s could not be formed within %d iterations.\n", word, c);
            return 1;
        }

        printf("[%d] %s == %s\n", ++c, word, new_word);

        if (i == 0)
        {
            new_word[j] = ALPHABET[i];
            i++;
        }
        else
        {
            if (new_word[j] == word[j])
            {
                j++;
                new_word[j] = ALPHABET[i];
                i = 0;
            }
            else
            {
                new_word[j] = ALPHABET[i];
                i++;
            }
        }

        if (j == strlen(word))
        {
            // remove last character
            new_word[j] = '\0';

            printf("The word %s is formed in %d iterations.\n", new_word, c);
            break;
        }
    }

    return 0;
}

int main()
{
    char word[100];

    getUserInput(word);
    return performBruteForce(word);
}