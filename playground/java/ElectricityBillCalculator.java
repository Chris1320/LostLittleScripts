/*
 * You are to write a program that will
 * calculate your electric bill. You are
 * to input the number of kilowatt-hour
 * used in a 31-day billing period.
 */

import java.util.Scanner;

public class ElectrictyBillCalculator
{
    public static void main(String[] args)
    {
        // ? Define and initialize variables.
        Scanner user_input = new Scanner(System.in);  // user input object

        double electricity_cost = 6.72;  // 6.72 cents per kilowatt-hour
        double state_tax = 8.0;  //   8% tax
        double city_tax = 3.5;  // 3.5% tax

        // ? Ask for user input.
        System.out.print("Enter the customer's name: ");
        String name = user_input.nextLine();

        System.out.print("Enter the number of KwH used in a month: ");
        double usage_in_31_days = user_input.nextDouble();  // How many KwH is used in 31 days.

        // ? Calculate the prices.
        double usage_price = usage_in_31_days * electricity_cost;  // Calculate how much is the used electricity.
        double applied_state_tax = (state_tax / 100) * usage_price;  // Calculate how much is the state tax.
        double applied_city_tax = (city_tax / 100) * usage_price;  // Calculate how much is the city tax.
        double total_price = usage_price + applied_city_tax + applied_state_tax;  // Add the tax to the total usage price.

        System.out.printf(  // ? Print the output.
            "\n\n\nElectricity bill for %s,\n\nState Tax: PHP %s (%s%7$s)\nCity Tax: PHP %s (%s%7$s)\nTotal Price: PHP %s\n\n",
            name,
            applied_state_tax,
            state_tax,
            applied_city_tax,
            city_tax,
            total_price,
            '%'
        );

        /*
         * Electricity bill for, <NAME>
         *
         * Amount of Electricity Bill is <total_price>
         *
         * State Tax: <applied_state_tax>
         * City Tax: <applied_city_tax>
         * Total: <total_price
         */
    }
}
