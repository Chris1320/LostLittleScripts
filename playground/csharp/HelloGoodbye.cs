using System;

namespace HelloGoodbye
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)  // Check how many arguments are passed to the program.
            {
                Console.WriteLine("Hello {0} and {1}.", args[0], args[1]);
                Console.WriteLine("Goodbye {1} and {0}.", args[0], args[1]);
            }
        }
    }
}
