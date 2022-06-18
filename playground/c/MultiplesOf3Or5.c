#include <stdio.h>

int main()
{
    int sum = 0;  // Initialize `sum` variable.

    for (int i = 0; i < 1000; i++)
    {
        if (i % 3 == 0 || i % 5 == 0)  // Check if i is divisible by 3 or 5
        {
            sum += i;  // Add to sum
        }
    }

    printf("%i", sum);
    printf("\n");

    return 0;
}