/*
 * Write a java program that will assign a value in a variable called V_Class and km.
 * The program will then identify the rate and additional fee according to the following.
 *
 * | Class | Rate | Additional Fee |
 * | 1     | 41   | 20 per km      |
 * | 2     | 102  | 35 per km      |
 * | 3     | 122  | 50 per km      |
 *
 * The program will also compute for the total amount to be paid according to the table above.
 * Formula is `rate + (km * additional fee)`.
 *
 * Test Data:
 * - Vehicle Class:  1
 * - Kilometer: 10
 * - Total Amount: 241
 *
 * - Vehicle Class: 3
 * - Kilometer: 10
 * - Total Amount: 622
 */

import java.util.Scanner;

public class HighwayToll
{
    public static void main(String[] args)
    {
        var user_input = new Scanner(System.in);
        float total_amount, km;
        short v_class;

        do
        {
            System.out.print("Vehicle Class (1/2/3): ");
            v_class = user_input.nextShort();
        }
        while (v_class < 1 || v_class > 3);

        System.out.print("Enter km: ");
        km = user_input.nextFloat();

        if (v_class == 1) total_amount = 41 + (km * 20);
        else if (v_class == 2) total_amount = 102 + (km * 35);
        else total_amount = 122 + (km * 50);

        System.out.printf("Total Amount: %.2f\n", total_amount);
    }
}
