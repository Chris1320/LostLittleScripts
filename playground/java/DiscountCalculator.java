/*
 * Create a java program, that takes two input values:
 * the original price and the discount percentage as integers
 * and returns the final price after the discount.
 */

import java.util.Scanner;

public class DiscountCalculator
{
    public static void main(String[] args)
    {
        // ? Define and initialize variables.
        Scanner user_input = new Scanner(System.in);
        int original_price, discount;
        double final_price;

        // ? Ask the user for input.
        System.out.print("Enter the original price of the product: ");
        original_price = user_input.nextInt();
        System.out.print("Enter the discount percentage: ");
        discount = user_input.nextInt();

        // ? Perform the operation.
        final_price = original_price - (original_price * (discount / 100.0));

        // ? Print the result.
        System.out.println("\nFinal price: " + final_price);
    }
}
