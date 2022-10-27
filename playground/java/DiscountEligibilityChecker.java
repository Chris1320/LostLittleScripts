/*
 * Design a program that will ask users to input their age and whether or not they have a discount coupon.
 * If the age is greater than 17, set the ticket price to be Php 350.00, and if the age is not greater than
 * 17, set the ticket price to Php 240.00. If the user has a discount coupon, reduce the ticket price by 25%.
 * Output the ticket price.
 */

import java.util.Scanner;  // For user input
import java.lang.Character;  // For char datatype manipulation

public class DiscountEligibilityChecker
{
    public static void main(String[] args)
    {
        // ? Define and initialize variables.
        var user_input = new Scanner(System.in);

        boolean has_discount_coupon;
        float ticket_price;
        char user_answer;  // used when asking user if they have a discount coupon.
        int age;

        // ? Ask for user input.
        do
        {
            System.out.print("Enter your age: ");
            age = user_input.nextInt();
        }
        while (age < 0);
        while (true)
        {
            System.out.print("Do you have a discount coupon? (y/n) > ");
            // Get the user input's first character and convert it to lowercase.
            user_answer = Character.toLowerCase(user_input.next().charAt(0));
            if (user_answer == 'y')
            {
                has_discount_coupon = true;
                break;  // Break out of the infinite loop.
            }
            else if (user_answer == 'n')
            {
                has_discount_coupon = false;
                break;  // Break out of the infinite loop.
            }
        }

        System.out.printf("Age: %s\n", age);
        System.out.printf("Has Discount Coupon: %s\n\n", has_discount_coupon);

        // ? Set the price of the ticket according to the rules.
        if (age > 17) ticket_price = 350;
        else ticket_price = 240;

        if (has_discount_coupon) ticket_price = ticket_price * 0.75F;  // They will only pay 75% of the actual price.

        System.out.printf("Your ticket will cost PHP %.2f only.\n", ticket_price);
    }
}
