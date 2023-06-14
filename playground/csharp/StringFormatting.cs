using System;

namespace StringFormatting
{
    class Program
    {
        static void Main()
        {
            string name = "Bob";
            int age = 15;

            // These two lines will output the same string.
            Console.WriteLine("{0}'s age is {1}.", name, age);
            Console.WriteLine($"{name}'s age is {age}.");
        }
    }
}
