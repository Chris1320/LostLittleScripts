/*
 * Hovercraft
 *
 * You run a hovercraft factory. Your factory makes ten hovercrafts in a month. Given
 * the number of customers you got that month, did you make a profit? It costs you
 * 2,000,000 to build a hovercraft, and you are selling them for 3,000,000. You
 * also pay 1,000,000 each month for insurance.
 *
 * Task:
 * Determine whether or not you made a profit based on how many of the ten
 * hovercrafts you were able to sell that month.
 *
 * Input Format:
 * An integer that represents the sales that you made that month.
 *
 * Output Format:
 * A string that says 'Profit', 'Loss', or 'Broke Even'.
 *
 * Sample Input:
 * 5
 *
 * Sample Output:
 * Loss
 */

#include <stdio.h>

int main() {
    // Declare variables.
    int sales, _;
    float profit, monthly_cost, cost = 2000000, sale = 3000000, expense = 1000000;
    monthly_cost = cost * 10;

    // Ask for user input.
    printf("How many sales did you make this month? > ");
    scanf("%i", &sales);

    profit = ((sale * sales) - monthly_cost) - expense;  // Calculate profit.
    if (profit > 0) printf("Profit\n");  // If profit > 0, we gained profit.
    else if (profit < 0) printf("Loss\n");
    else printf("Broke Even\n");

    return 0;
}

