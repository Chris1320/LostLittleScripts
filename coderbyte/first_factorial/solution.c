#include <stdio.h>

int firstFactorial(int n, int total);

int main(int argc, char *argv[])
{
    int input;

    printf("Enter a number: ");
    scanf("%d", &input);
    printf("%d\n", firstFactorial(input, 1));

    return 0;
}

/// @brief This function calculates the factorial of a number.
/// @param n The number to calculate the factorial.
/// @param total The total of the factorial.
/// @return The factorial of the number.
int firstFactorial(int n, int total)
{
    if (n == 1)
        return total;
    return firstFactorial(n - 1, total * n);
}
