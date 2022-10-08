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

        int value_dec = 0;
        bool show_output = false;
        string value_bin = "0", value_oct = "0", value_hex = "0";

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
                        value_dec = decimal_converter.val;
                        value_bin = decimal_converter.toBinary();
                        value_oct = decimal_converter.toOctal();
                        value_hex = decimal_converter.toHexadecimal();
                        show_output = true;
                        break;

                    case '2':  // Binary
                        var binary_converter = new Binary(source_value);
                        value_dec = binary_converter.toDecimal();
                        value_bin = binary_converter.val;
                        value_oct = binary_converter.toOctal();
                        value_hex = binary_converter.toHexadecimal();
                        show_output = true;
                        break;

                    case '3':  // Octal
                        var octal_converter = new Octal(source_value);
                        value_dec = octal_converter.toDecimal();
                        value_bin = octal_converter.toBinary();
                        value_oct = octal_converter.val;
                        value_hex = octal_converter.toHexadecimal();
                        show_output = true;
                        break;

                    case '4':  // Hexadecimal
                        var hex_converter = new Hexadecimal(source_value);
                        value_dec = hex_converter.toDecimal();
                        value_bin = hex_converter.toBinary();
                        value_oct = hex_converter.toOctal();
                        value_hex = hex_converter.val;
                        show_output = true;
                        break;

                    default:  // If no options matched
                        show_output = false;
                        Console.WriteLine("[!] Unknown option. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }

                if (show_output)
                {
                    Console.WriteLine($"Decimal:     {value_dec}");
                    Console.WriteLine($"Binary:      {value_bin}");
                    Console.WriteLine($"Octal:       {value_oct}");
                    Console.WriteLine($"Hexadecimal: {value_hex}");
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"[ERROR] {e.Message}");
                Console.Write("Press any key to continue...");
                    Console.ReadKey();
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
