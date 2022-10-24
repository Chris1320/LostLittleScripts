public class VariableTypes
{
    public static void main(String[] args)
    {
        // ? Primitive Types
        // integers
        byte a_single_byte = 100; // -128 to 127
        short a_small_number = 20000; // -32.768 to 32,767
        int an_integer = 2147483647; // -9223372036854775808 to 9223372036854775807
        long a_long_integer = 123456789012345678L;

        // decimals
        double a_double = 1.79769313; // 4.9E-324 to 1.7976931348623157E308
        float a_float = 3.4028F; // 1.4E-45 to 3.4028235E38

        // booleans
        boolean a_boolean = true; // true or false

        // characters
        char a_character = '\u006A';

        System.out.println(a_single_byte);
        System.out.println(a_small_number);
        System.out.println(an_integer);
        System.out.println(a_long_integer);
        System.out.println(a_double);
        System.out.println(a_float);
        System.out.println(a_boolean);
        System.out.println(a_character);
    }
}
