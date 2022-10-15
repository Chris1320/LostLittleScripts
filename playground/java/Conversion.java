public class Conversion {
    public static void main(String[] args)
    {
        int num1 = 52;
        double num2 = num1;  // This will implicitly convert num1 to float.

        double num3 = 25.125;
        int num4 = (int)num3; // This will explicitly convert num3 to int.

        System.out.println(num1);
        System.out.println(num2);
        System.out.println(num3);
        System.out.println(num4);
    }
}
