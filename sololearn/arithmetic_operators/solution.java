import java.util.Scanner;

public class Solution {
    public static void main(String[] args)
    {
        int a, b;
        Scanner user_input = new Scanner(System.in);

        System.out.print("Enter the first number: ");
        a = user_input.nextInt();
        System.out.print("Enter the second number: ");
        b = user_input.nextInt();

        System.out.println(a + b);
        System.out.println(a - b);
        System.out.println(a * b);
    }
}
