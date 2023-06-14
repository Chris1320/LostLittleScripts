using System;

namespace Variables
{
    class Program
    {
        static void Main()
        {
            const double PI = 3.14;  // A constant variable.
            var a_letter = 'C';  // `var` infers the datatype of the variable.
            string username;
            int userage;

            Console.Write("Enter your name: ");
            username = Console.ReadLine();
            Console.Write("Enter your age: ");
            userage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"PI = {PI}");
            Console.WriteLine($"Letter = {a_letter}");
            Console.WriteLine($"\n{username}'s age is {userage}.");
        }
    }
}
