import java.util.Scanner;

/**
 * - Accepts a number from 1 to 7
 * - Uses a switch statement to print the corresponding day of the week
 * - If the number is outside 1–7, print "Invalid input"
 * - Additionally print whether it is a Weekday or Weekend
 */

class DayOfTheWeek {
    public static void main(String[] args) {
        if (args.length != 1) {
            System.out.println("Usage: java DayOfTheWeek.java <day_number>");
            return;
        }

        try {
            int n = Integer.parseInt(args[0]);
            if (n < 1 || n > 7) {
                System.out.println("Invalid input.");
                return;
            }
            switch (n) {
                case 1:
                    System.out.println("Day: Monday\nType: Weekday");
                    break;

                case 2:
                    System.out.println("Day: Tuesday\nType: Weekday");
                    break;

                case 3:
                    System.out.println("Day: Wednesday\nType: Weekday");
                    break;

                case 4:
                    System.out.println("Day: Thursday\nType: Weekday");
                    break;

                case 5:
                    System.out.println("Day: Friday\nType: Weekday");
                    break;

                case 6:
                    System.out.println("Day: Saturday\nType: Weekend");
                    break;

                case 7:
                    System.out.println("Day: Sunday\nType: Weekend");
                    break;

                default:
                    System.out.println("Invalid input.");
                    break;
            }

        } catch (NumberFormatException e) {
            System.out.println("Please enter a number between 1 and 7.");
            return;
        }
    }
}
