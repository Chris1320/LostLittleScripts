/* Write a program that calculates and prints the
 * monthly paycheck for an employee. The net pay is
 * calculated after taking the following deductions:
 *
 * Federal Income Tax:    15.00%
 * State Security Tax:     3.50%
 * Social Security Tax:    5.75%
 * Medicare/Medicaid Tax:  2.75%
 * Pension Plan:           5.00%
 * Health Insurance:       2.00%
 *
 * Your program should prompt the user to input the
 * gross amount and the employee's name. The output
 * will be stored in a file. A sample output follows:
 *
 * Allison Shield
 *
 * Gross Amount          3575.00
 * Federal Tax            536.25
 * State Tax              125.13
 * Social Security Tax    205.56
 * Medicare/Medicaid Tax   98.31
 * Pension Plan           178.75
 * Health Insurance        71.50
 * Net Pay               2359.50
 */

#include <iostream>
#include <fstream>  // For file I/O

#define DEFAULT_OUTPUT_FILE "paycheck.txt"  // Default output filepath
// Taxes and deductions in percentage form
#define FEDERAL_INCOME_TAX 15.00
#define STATE_SECURITY_TAX 3.50
#define SOCIAL_SECURITY_TAX 5.75
#define MEDICARE_TAX 2.75
#define PENSION_PLAN 5.00
#define HEALTH_INSURANCE 2.00

using std::cin;
using std::cout;
using std::string;

/**
 * Format the employee's salary information.
 *
 * @param employee_name              The employee's name.
 * @param gross_amount               The gross amount.
 * @param federal_income_tax_amount  The federal income tax amount.
 * @param state_security_tax_amount  The state security tax amount.
 * @param social_security_tax_amount The social security tax amount.
 * @param medicare_tax_amount        The medicare tax amount.
 * @param pension_plan_amount        The pension plan amount.
 * @param health_insurance_amount    The health insurance amount.
 * @param net_pay                    The net pay.
 * @return The formatted string.
 */
string formatEmployeeSalaryReport(
    string employee_name,
    double gross_amount,
    double federal_income_tax_amount,
    double state_security_tax_amount,
    double social_security_tax_amount,
    double medicare_tax_amount,
    double pension_plan_amount,
    double health_insurance_amount,
    double net_pay
) {
    using std::to_string;

    // FIXME: kinda messy and possibly bad practice; needs improvement.
    // TODO: Round off the values to 2 decimal places.
    return employee_name + "\n\n"
        + "Gross Amount\t\t" + to_string(gross_amount) + "\n"
        + "Federal Tax\t\t" + to_string(federal_income_tax_amount) + "\n"
        + "State Tax\t\t" + to_string(state_security_tax_amount) + "\n"
        + "Social Security Tax\t" + to_string(social_security_tax_amount) + "\n"
        + "Medicare/Medicaid Tax\t" + to_string(medicare_tax_amount) + "\n"
        + "Pension Plan\t\t" + to_string(pension_plan_amount) + "\n"
        + "Health Insurance\t" + to_string(health_insurance_amount) + "\n"
        + "\nNet Pay\t\t\t" + to_string(net_pay) + "\n";
}

/**
 * This is the main function of the program.
 *
 * @return The exit code.
 */
int main() {
    string employee_name;
    double gross_amount;

    // ? Step 1: Ask for employee's name.
    cout << "Please enter your name >> ";
    getline(cin, employee_name);

    // ? Step 2: Ask for the employee's gross amount.
    printf("Hello, %s.\nHow much is your gross pay? >> ", employee_name.c_str());
    cin >> gross_amount;

    // ? Step 3: Calculate the deductions and net pay.
    cout << "[i] Calculating net pay...\n" << std::endl;
    double federal_income_tax_amount = gross_amount * (FEDERAL_INCOME_TAX / 100);
    double state_security_tax_amount = gross_amount * (STATE_SECURITY_TAX / 100);
    double social_security_tax_amount = gross_amount * (SOCIAL_SECURITY_TAX / 100);
    double medicare_tax_amount = gross_amount * (MEDICARE_TAX / 100);
    double pension_plan_amount = gross_amount * (PENSION_PLAN / 100);
    double health_insurance_amount = gross_amount * (HEALTH_INSURANCE / 100);
    double net_pay = gross_amount
        - federal_income_tax_amount
        - state_security_tax_amount
        - social_security_tax_amount
        - medicare_tax_amount
        - pension_plan_amount
        - health_insurance_amount;

    // ? Step 4: Format the result.
    string result = formatEmployeeSalaryReport(
        employee_name,
        gross_amount,
        federal_income_tax_amount,
        state_security_tax_amount,
        social_security_tax_amount,
        medicare_tax_amount,
        pension_plan_amount,
        health_insurance_amount,
        net_pay
    );

    // ? Step 5: Print and save the results to a file.
    cout << result << std::endl;
    printf("[i] Saving results to `%s`...\n", DEFAULT_OUTPUT_FILE);
    std::ofstream file(DEFAULT_OUTPUT_FILE);
    file << result;
    file.close();

    // ? Step 6: Exit the program.
    cout << "[i] Done." << std::endl;
    return 0;
}
