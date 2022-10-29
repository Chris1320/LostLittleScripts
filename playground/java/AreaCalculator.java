import java.util.Scanner;

public class AreaCalculator
{
    public static void main(String[] args)
    {
        Scanner user_input = new Scanner(System.in);
        int menu_choice;

        // We will use doubles below to be accurate.

        // Used for circle
        final double PI = 3.14159;
        double radius;

        // Used for rectangle
        double length, width;

        // Used for right triangle
        double base, height;

        // Used for square
        double side;

        while (true)  // Enter infinite loop.
        {
            System.out.println("\nArea Calculator\n");
            System.out.println("[01] Circle");
            System.out.println("[02] Rectangle");
            System.out.println("[03] Right Triangle");
            System.out.println("[04] Square\n");
            System.out.println("[99] Quit");

            System.out.print(" >>> ");
            menu_choice = user_input.nextInt();
            switch (menu_choice)
            {
                case 99: return;  // End the infinite loop.

                case 1:  // Calculate Circle.
                    System.out.print("Radius: ");
                    radius = user_input.nextDouble();

                    System.out.println("\nArea of Circle: " + (PI * radius * radius));
                    break;

                case 2:  // Calculate Rectangle.
                    System.out.print("Length: ");
                    length = user_input.nextDouble();
                    System.out.print("Width: ");
                    width = user_input.nextDouble();

                    System.out.println("\nArea of Rectangle: " + (length * width));
                    break;

                case 3:  // Calculate Right Triangle
                    System.out.print("Base: ");
                    base = user_input.nextDouble();
                    System.out.print("Height: ");
                    height = user_input.nextDouble();

                    System.out.println("\nArea of Right Triangle: " + (base * height * 0.5));
                    break;

                case 4:  // Calculate Square
                    System.out.print("Side: ");
                    side = user_input.nextDouble();

                    System.out.println("\nArea of Square: " + (side * side));
                    break;

                default:
                    System.out.println("\n[ERROR] Unknown option.");
                    break;
            }
        }
    }
}
