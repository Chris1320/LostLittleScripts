#include <stdio.h>

int main()
{
    int sequence_length;
    int x = 1;
    int y = 1;
    int z;

    printf("How many Fibonacci numbers should be printed? > ");
    scanf("%i", &sequence_length);
    printf("\nListing %i Fibonacci numbers...\n\n", sequence_length);

    if (sequence_length < 1)
    {
        return 0;
    }

    printf("[1] %i\n", x);
    if (sequence_length < 2)
    {
        return 0;
    }

    printf("[2] %i\n", y);
    for (int i = 2; i < sequence_length; i++)
    {
        z = x + y;  // Calculate the next number in the sequence.
        x = y;  // Move y to x and z to y to be ready for the next iteration.
        y = z;
        printf("[%i] %i\n", i + 1, z);
    }

    return 0;
}
