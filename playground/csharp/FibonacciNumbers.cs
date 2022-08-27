using System;

namespace Program
{
    class FibonacciNumbers
    {
        static int Main()
        {
            int sequence_length;
            int x = 1;  // x and y are the first two numbers of the Fibonacci sequence.
            int y = 1;
            int z;

            Console.Write("How many Fibonacci numbers should be seen? > ");
            sequence_length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nPrinting {sequence_length} Fibonacci numbers...\n");
            Console.WriteLine($"[1] {x}\n[2] {y}");

            for (int i = 2; i < sequence_length; i++)
            {
                z = x + y;
                x = y;
                y = z;
                Console.WriteLine($"[{i + 1}] {z}");
            }

            return 0;
        }
    }
}
