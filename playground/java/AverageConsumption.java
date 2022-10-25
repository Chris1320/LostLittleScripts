/*
 * Sample Input:
 * Enter the total distance in kilometers: 350
 * Enter total fuel spent in liters: 5
 *
 * Sample Output:
 * Average consumption: 70.0 km/L
 */

import java.util.Scanner;

public class AverageConsumption
{
    public static void main(String[] args)
    {
        // ? Define and initialize variables.
        Scanner user_input = new Scanner(System.in);
        double total_distance, total_fuel_spent;

        // ? Ask user input.
        System.out.print("Enter the total distance in kilometers: ");
        total_distance = user_input.nextDouble();
        System.out.print("Enter total fuel spent in liters: ");
        total_fuel_spent = user_input.nextDouble();

        // ? Print result.
        System.out.printf(
            "Average consumption: %s km/L\n",
            (total_distance / total_fuel_spent)
        );
        user_input.close();
    }
}
