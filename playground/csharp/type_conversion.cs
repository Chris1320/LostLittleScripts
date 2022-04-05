using System;

namespace TypeConversion
{
    class Program
    {
        static int Main(string[] args)
        {
            int num1, num2;
            double quotient;

            Console.Write("Enter int for num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter int for num1: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            quotient = (double) num1 / num2;  // Explicit type conversion
            Console.WriteLine(quotient);

            return 0;
        }
    }
}