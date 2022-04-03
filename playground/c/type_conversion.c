#include <stdio.h>

int main()
{
    float price;
    int added;
    float total;

    printf("Enter the prince (float): ");
    scanf("%f", &price);
    printf("\nEnter the added amount (int): ");
    scanf("%i", &added);

    total = (float) price + added;  // Explicit tyoe conversion
    printf("\n%.2f\n", total);
    return 0;
}
