class Program
{
    public static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: part1 <input_file>");
            return 1;
        }

        uint sum = 0;
        uint lines = 0;

        try
        {
            using (var reader = new StreamReader(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    Console.WriteLine($"Processing line #{++lines}: {line}");
                    if (String.IsNullOrWhiteSpace(line))
                        continue;

                    char[] row_chars = line.ToCharArray();
                    foreach (var c in row_chars)
                        if (Char.IsNumber(c))
                        {
                            sum += (uint)Char.GetNumericValue(c) * 10;
                            break;
                        }
                    for (int i = row_chars.Length - 1; i >= 0; i--)
                        if (Char.IsNumber(row_chars[i]))
                        {
                            sum += (uint)Char.GetNumericValue(row_chars[i]);
                            break;
                        }
                }
            }

            Console.WriteLine($"Processed {lines} lines.");
            Console.WriteLine($"Total: {sum}");
            return 0;
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
            return 1;
        }
    }
}
