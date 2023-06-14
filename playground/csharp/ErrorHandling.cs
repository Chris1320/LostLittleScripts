using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number #1: ");
            // The program will crash here if the user
            // enters an invalid number.
            int number1 = Convert.ToInt32(Console.ReadLine());

            try {
                Console.Write("Enter number #2: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            }
            // "Catch" the error.
            catch (System.Exception) {
                Console.WriteLine("An error occured. Exiting properly.");
            }
        }
    }
}
