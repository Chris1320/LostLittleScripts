#include <stdio.h>

int main()
{
    // Declare variables.
    float price, total;
    int added;

    // Ask for user input.
    printf("Enter the prince (float): ");
    scanf("%f", &price);
    printf("\nEnter the added amount (int): ");
    scanf("%i", &added);

    total = (float) price + added;  // Explicit type conversion
    printf("\n%.2f\n", total);

    return 0;
}
