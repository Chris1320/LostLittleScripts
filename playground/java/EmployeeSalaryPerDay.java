/*
 * Sample Input:
 * Employee ID: 0342
 * Working Hours: 8
 * Salary per hour: 15000
 *
 * Sample Output:
 * Employee ID: 0342
 * Salary: PHP 120000.0/day
 */

import java.util.Scanner;

public class EmployeeSalaryPerDay
{
    public static void main(String[] args)
    {
        // ? Define and initialize variables
        Scanner user_input = new Scanner(System.in);

        String employee_id;  // The employee ID.
        int working_hours;  // Total worked hours of a month.
        double salary_per_hour;  // The amount received per hour.

        // ? Ask for user input.
        System.out.print("Employee ID: ");
        employee_id = user_input.nextLine();
        System.out.print("Working Hours: ");
        working_hours = user_input.nextInt();
        System.out.print("Salary per hour: ");
        salary_per_hour = user_input.nextDouble();

        // ? Print employee information.
        System.out.println("\nEmployee ID: " + employee_id);
        System.out.println("Salary: PHP " + (working_hours * salary_per_hour) + "/day");
        user_input.close();
    }
}
