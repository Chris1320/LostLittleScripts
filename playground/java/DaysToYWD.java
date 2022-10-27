/*
 * Write a java program to input number of days from user
 * and convert it to years, weeks, and days.
 */

import java.util.Scanner;

public class DaysToYWD
{
    public static void main(String[] args)
    {
        // ? Define and initialize variables.
        Scanner user_input = new Scanner(System.in);
        double years, weeks, days;  // Use `double` because there might be "1.5 years, etc."

        // ? Ask for user input.
        System.out.print("Enter the number of days to convert: ");
        days = user_input.nextDouble();

        // ? Perform the operations.
        years = days / 365.25;  // There are 365.25 days in a year including leap years.
        weeks = (days % 365.25) / 7;  // There are 7 days in a week.
        days = (days % 365.25) % 7;

        // ? Print the result.
        System.out.printf("%s days is equivalent to...\n", days);
        System.out.printf("\t- %s years\n", years);
        System.out.printf("\t- %s weeks\n", weeks);
        System.out.printf("\t- %s days\n", days);
    }
}
