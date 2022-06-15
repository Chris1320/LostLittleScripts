/*
 * "Hello World!" in C
 *
 * Objective:
 *     In this challenge, we will learn some basic concepts of C that will get you
 *     started with the language. You will need to use the same syntax to read input
 *     and write output in many C challenges. As you work through these problems,
 *     review the code stubs to learn about reading from stdin and writing to stdout.
 *
 * Task:
 *     This challenge requires you to print "Hello, World!" on a singe line, and then
 *     print the already provided input string to stdout. If you are not familiar with C,
 *     you may want to read about the printf() command.
 *
 * Example:
 *     s = "Life is beautiful"
 *
 *     The required output is:
 *         Hello, World!
 *         Life is beautiful
 *
 * Function Description:
 *     Complete the main() function below.
 *
 *     The main() function has the following input:
 *         - string s: a string
 *
 * Prints:
 *     - *two strings*: "Hello, World!" on one line and the input string on the next line.
 *
 * Input Format:
 *     There is one line of text, s.
 *
 * Sample Input 0:
 *     Welcome to C programming.
 *
 * Sample Output 0:
 *     Hello, World!
 *     Welcome to C programming.
 */

#include <stdio.h>

int main()
{

    char s[100];
    scanf("%[^\n]%*c", &s);

    /* Enter your code here. Read input from STDIN. Print output to STDOUT */
    printf("Hello, World!\n%s", s);
    return 0;
}
