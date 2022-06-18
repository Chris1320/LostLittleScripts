/*
 * Instructions: Command-line arguments.
 * Write a program that takes two names as command-line
 * arguments and prints hello and goodbye messages as shown
 * below (with the names for the hello message in the same
 * order as the command-line arguments and with the names
 * for the goodbye message in reverse order).
 */

#include <stdio.h>

int main(int argc, char *argv[])
{
    if (argc == 3)  // Check if there are three
    {
        // argv[0] is the name of the program.
        printf("Hello %s and %s.\n", argv[1], argv[2]);
        printf("Goodbye %s and %s.\n", argv[2], argv[1]);
    }
    return 0;
}
