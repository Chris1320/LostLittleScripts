public class Variables
{
    public static void main(String[] args)
    {
        double pi;  // Declaration
        pi = 3.14; // Definition
        int num1 = 19;  // Initialization
        long credit_card_number = 1234_5678_9012_3456L;  // You can put underscores in numeric literals.

        // The keyword `new` is not used when initializing a primitive data type.

        System.out.println("The value of pi is " + pi + '.');
        System.out.println("num1 is " + num1 + '.');
        System.out.println("Credit card number: " + credit_card_number);
    }
}
