import java.util.Scanner;

/**
 * Accept the number of kilowatt hours (kWh) consumed and
 * compute the electricity bill based on this rate:
 *
 * | Consumption            | Rate per kWh |
 * | ---------------------- | ------------ |
 * | First 100 kWh          | PHP 5.00     |
 * | Next 100 kWh (101–200) | PHP 8.00     |
 * | Next 100 kWh (201–300) | PHP 10.00    |
 * | Above 300 kWh          | PHP 12.00    |
 *
 * Add a fixed monthly charge of PHP 50.00 to the total and
 * print the total electricity bill
 *
 * Hint: Each tier is charged separately. For 250 kWh — first
 * 100 at PHP 5, next 100 at PHP 8, remaining 50 at PHP 10.
 */

class ConsumptionBasedPricing {
    public static double getTotalBill(double kwh) {
        double totalBill = 50;  // Add fixed monthly charge
        if (kwh > 300) {  // Above 300 kWh
            totalBill += (kwh - 300) * 12;
            kwh = 300;
        }
        if (kwh > 200) {  // Next 100 kWh (201–300)
            totalBill += (kwh - 200) * 10;
            kwh = 200;
        }
        if (kwh > 100) {  // Next 100 kWh (101–200)
            totalBill += (kwh - 100) * 8;
            kwh = 100;
        }
        totalBill += kwh * 5;  // First 100 kWh
        return totalBill;
    }

    public static void main(String[] args) {
        try (var scanner = new Scanner(System.in)) {
            System.out.print("Enter the number of kilowatt hours (kWh) consumed: ");
            double kwh = scanner.nextDouble();
            if (kwh < 0) {
                System.out.println("Invalid input. Please enter a non-negative number.");
                return;
            }
            var totalBill = getTotalBill(kwh);
            System.out.printf("Total electricity bill: PHP %.2f%n", totalBill);
        }
    }
}
