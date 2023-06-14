using System;

namespace Overflowing
{
    class Program
    {
        static void Main()
        {
            // For example, we have a game that have this
            // `max_health` variable, and the user aquired
            // a healing potion.
            byte max_health = 255;

            Console.WriteLine($"Health before consuming potion: {max_health}");  // 255
            max_health += 1;
            Console.WriteLine($"Health after consuming potion: {max_health}");  // 0

            checked
            {
                byte max = 255;
                Console.WriteLine($"Checked variable (before): {max}");
                max += 1;  // This will throw a `System.OverflowException`.
                           // Exception handling will be required here
                           // to prevent the program from crashing.
                Console.WriteLine($"Checked variable (after): {max}");
            }
        }
    }
}
