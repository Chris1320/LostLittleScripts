import java.util.Scanner;

public class Operators {
    public static void main(String[] args)
    {
        Scanner user_input = new Scanner(System.in);

        System.out.print("Enter num1: ");
        double num1 = user_input.nextDouble();
        System.out.print("Enter num2: ");
        double num2 = user_input.nextDouble();

        System.out.println(num1 + num2);
        System.out.println(num1 - num2);
        System.out.println(num1 * num2);
        System.out.println(num1 / num2);
        System.out.println(num1 % num2);
    }
}
