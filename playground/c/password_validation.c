/*
 * Password Validation
 *
 * You're interviewing to join a security team. They want to see you build a
 * password evaluator for your technical interview to validate the input.
 *
 * Task:
 * Write a program that takes in a string as input and evaluates it as a
 * valid password. The password is valid if it has at a minimum 2 numbers,
 * 2 of the following special characters ('!', '@', '#', '$', '%', '&', '*'),
 * and a length of at least 7 characters.
 * If the password passes the check, output 'Strong', else output 'Weak'.
 *
 * Input Format:
 * A string representing the password to evaluate.
 *
 * Output Format:
 * A string that says 'Strong' if the input meets the requirements, or 'Weak', if not
 * 
 * Sample Input:
 * Hello@$World19
 *
 * Sample Output:
 * Strong
 */

#include <stdio.h>
#include <ctype.h>  // For checking type of character.
#include <string.h>  // For getting string length

int main()
{
    // Declare and assign variables
    char password[40];
    int i, digits = 0, symbols = 0, required_digits = 2, required_symbols = 2;;

    // Ask for user input.
    printf("Enter your password: ");
    scanf("%40s", password);

    if (strlen(password) >= 7)  // Check password length before checking for other things.
    {
        for (i = 0; i < strlen(password); i++)  // Iterate through each character in <password>.
        {
            if (isdigit(password[i])) digits++;  // If character is a number, add 1 to <digits>.
            else if (ispunct(password[i])) symbols++;  // If character is a punctuation, add 1 to <symbols>.
        }
        if (digits < required_digits || symbols < required_symbols) printf("Weak\n");  // If it does not meet the requirements, print "Weak".
        else printf("Strong\n");
    }
    else printf("Weak\n");
    return 0;
}
