/*
 * Write a program that inputs the number of seconds and outputs the
 * hours, minutes and seconds equivalent.
 */

import java.util.Scanner;

public class SecondsToHMS
{
    public static void main(String[] args)
    {
        Scanner user_input = new Scanner(System.in);

        System.out.print("Enter the seconds to convert: ");
        int sec_in = user_input.nextInt();

        int hours = (sec_in / 3600);
        int minutes = (sec_in % 3600) / 60;
        int seconds = ((sec_in % 3600) % 60);

        System.out.println(
            "Hours: " + hours +
            "\nMinutes: " + minutes +
            "\nSeconds: " + seconds
        );
    }

}
