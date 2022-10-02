class Program
{
    /// <summary>
    /// This is the main class of the program.
    /// </summary>

    static int Main(string[] args)
    {
        /// <summary>
        /// The main method of the program.
        /// </summary>

        bool debug_mode = false;

        char option;
        string? source_value;  // Declare a nullable string.

        while (true)  // Loops to ask user what operation to do.
        {
            try
            {
                Console.Clear();  // Clear the screen.
                Console.WriteLine($"\nBase Converter\n\n[1] Decimal\n[2] Binary\n[3] Octal\n[4] Hexadecimal\n\n[Q] Quit\n");
                if (debug_mode) Console.WriteLine("WARNING: Debug mode enabled.\n");
                Console.Write("Choose an option > ");
                option = Console.ReadKey().KeyChar;  // Get the input of the user.
                Console.WriteLine();

                if (Char.ToUpper(option) == 'Q')  // Exits the loop if option is `Q`.
                {
                    Console.WriteLine("Exiting...");
                    return 0;
                }
                else if (Char.ToUpper(option) == 'D')
                {
                    debug_mode = !debug_mode;  // Toggle debug mode.
                    continue;
                }
                else
                {
                    do  // The user must enter a valid source number.
                    {
                        Console.Write("Enter the source number: ");
                        source_value = Console.ReadLine();
                    }
                    while (source_value == null || source_value == "");
                }

                switch (option)
                {
                    case '1':  // Decimal
                        var decimal_converter = new Decimal(source_value);
                        Console.WriteLine($"Decimal:     {decimal_converter.val}");
                        Console.WriteLine($"Binary:      {decimal_converter.toBinary()}");
                        Console.WriteLine($"Octal:       {decimal_converter.toOctal()}");
                        Console.WriteLine($"Hexadecimal: {decimal_converter.toHexadecimal()}");
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;

                    case '2':  // Binary
                        var binary_converter = new Binary(source_value);
                        Console.WriteLine($"Decimal:     {binary_converter.toDecimal()}");
                        Console.WriteLine($"Binary:      {binary_converter.val}");
                        Console.WriteLine($"Octal:       {binary_converter.toOctal()}");
                        Console.WriteLine($"Hexadecimal: {binary_converter.toHexadecimal()}");
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;

                    case '3':  // Octal
                        var octal_converter = new Octal(source_value);
                        Console.WriteLine($"Decimal:     {octal_converter.toDecimal()}");
                        Console.WriteLine($"Binary:      {octal_converter.toBinary()}");
                        Console.WriteLine($"Octal:       {octal_converter.val}");
                        Console.WriteLine($"Hexadecimal: {octal_converter.toHexadecimal()}");
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;

                    case '4':  // Hexadecimal
                        var hex_converter = new Hexadecimal(source_value);
                        Console.WriteLine($"Decimal:     {hex_converter.toDecimal()}");
                        Console.WriteLine($"Binary:      {hex_converter.toBinary()}");
                        Console.WriteLine($"Octal:       {hex_converter.toOctal()}");
                        Console.WriteLine($"Hexadecimal: {hex_converter.val}");
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;

                    default:  // If no options matched
                        Console.WriteLine("[!] Unknown option. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("[ERROR] Invalid input.");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"[CRITICAL] {e.Message}");
                if (debug_mode) throw;
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
