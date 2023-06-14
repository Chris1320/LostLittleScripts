using System;

namespace TypeConversion
{
    class Program
    {
        static int Main(string[] args)
        {
            int num1, num2;
            double quotient;

            Console.Write("Enter byte for num1: ");
            // This will perform an implicit type conversion
            // because the input is converted into `byte`,
            // but the variable is of `int` datatype.
            //
            // Example value:                          1
            // byte:                            00000001
            // int:  00000000 00000000 00000000 00000001
            num1 = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter int for num2: ");
            // The `Convert` class is used for converting
            // non-compatible types, which in this case
            // is a string being converted into an integer.
            //
            // Another option is the datatype's `.Parse()`
            // method.
            num2 = Convert.ToInt32(Console.ReadLine());

            // Explicit type conversion, a.k.a Casting
            quotient = (double) num1 / num2;
            Console.WriteLine(quotient);

            return 0;
        }
    }
}
