using System;

namespace OverflowException
{
    class Program
    {
        static int Main(string[] args)
        {
            short num1, num2;  // Initialize two Int16 variables.

            Console.Write("Enter num1: ");
            num1 = Convert.ToInt16(Console.ReadLine());  // Maximum value of Int16 is 32767.
            Console.Write("Enter num2: ");               // If you enter 32768, it will raise
            num2 = Convert.ToInt16(Console.ReadLine());  // a `System.OverflowException` exception.

            Console.WriteLine("num1 + num2 = num3");
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

            return 0;
        }
    }
}
