/*
 * Employees at a particular company have gained a 7.5% salary increase.
 * Moreover, the increase is retroactive for three months. Write a Java
 * program that takes an employee's previous annual salary as input and
 * outputs the amount of retroactive pay, the new annual salary, and the
 * new monthly salary. Use JOptionPane.
 */

import javax.swing.JOptionPane;

public class Main
{
    public static void main(String[] args)
    {
        double new_annual_salary, new_monthly_salary, prev_annual_salary;
        double total_salary_increase, salary_increase = 0.075F;  // 7.5% salary increase
        int retroactive_pay = 3;  // 3 months

        prev_annual_salary = Double.parseDouble(
            JOptionPane.showInputDialog(null, "Enter your previous annual salary")
        );

        new_monthly_salary = prev_annual_salary / 12.0;
        total_salary_increase = new_monthly_salary + (new_monthly_salary * salary_increase);
        new_annual_salary = (
            new_monthly_salary * (12.0 - retroactive_pay)
        ) + (total_salary_increase * retroactive_pay);

        JOptionPane.showMessageDialog(
            null,
            String.format(
                "Retroactive Pay:    %d Months\nNew Annual Salary:  %.2f\nNew Monthly Salary: %.2f",
                retroactive_pay,
                new_annual_salary,
                new_monthly_salary
            ),
            "Employee Salary Increase",
            JOptionPane.INFORMATION_MESSAGE
        );
    }
}
