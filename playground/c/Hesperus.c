/*
 * Taken from "C by Dissection, 4th Edition"
 */

#include <stdio.h>

int main(int argc, char *argv[])
{
    int fathoms, feet, inches;

    fathoms = 7;
    feet = fathoms * 6;
    inches = feet * 12;

    printf("Wreck of the Hesperus:\n\n");
    printf("Its depth at the sea in different units:\n");
    printf("- %d fathoms\n", fathoms);
    printf("- %d feet\n", feet);
    printf("- %d inches\n", inches);

    return 0;
}
