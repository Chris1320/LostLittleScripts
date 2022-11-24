#include <stdio.h>

int main()
{
    // ? Declare variables.
    int quantity;
    double total;

    // ? Ask user how many entries they want to enter.
    printf("How many numbers do you want to enter? > ");
    scanf("%d", &quantity);

    double numbers[quantity];  // declare the array.

    // ? Let user fill the array.
    for (int i = 0; i < quantity; i++)
    {
        printf("Enter number %d: ", i + 1);
        scanf("%lf", &numbers[i]);
    }

    // ? Print the output.
    printf("\nYou entered the following numbers:\n");
    for (int i = 0; i < quantity; i++) printf("- %.2f\n", numbers[i]);

    for (int i = 0; i < quantity; i++) total += numbers[i];
    printf("\nAverage: %.2f\n", total / quantity);

    return 0;
}
