import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    {
        Scanner user_input = new Scanner(System.in);
        System.out.print("Enter the height of the rectangle: ");
        int height = user_input.nextInt();
        System.out.print("Enter the width of the rectangle: ");
        int width = user_input.nextInt();

        System.out.println("The area of " + height + 'x' + width + " is " + (height * width) + '.');
    }
}
