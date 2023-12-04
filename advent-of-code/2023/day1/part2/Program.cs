class Program
{
    public static Dictionary<string, uint> NUMBER_WORD_VALUES = new Dictionary<string, uint>()
    {
        { "one", 1 },
        { "two", 2 },
        { "three", 3 },
        { "four", 4 },
        { "five", 5 },
        { "six", 6 },
        { "seven", 7 },
        { "eight", 8 },
        { "nine", 9 }
    };

    public static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: part2 <input_file>");
            return 1;
        }

        uint sum = 0; // The total sum of the calibration values.
        uint lines_processed = 0;

        try
        {
            using (var reader = new StreamReader(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    if (String.IsNullOrWhiteSpace(line))
                        continue;

                    Console.WriteLine($"Line #{++lines_processed}: {line}");
                    sum += getFirstNumber(line) * 10 + getLastNumber(line);
                }
            }

            Console.WriteLine($"Processed {lines_processed} lines.");
            Console.WriteLine($"Total: {sum}");
            return 0;
        }
        catch (Exception e) when (e is IndexOutOfRangeException || e is FileNotFoundException)
        {
            Console.WriteLine(e.Message);
            return 1;
        }
    }

    public static uint getFirstNumber(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsDigit(str[i]))
                return (uint)Char.GetNumericValue(str[i]);

            foreach (var number_word in NUMBER_WORD_VALUES)
                if (str.Substring(i).StartsWith(number_word.Key))
                    return number_word.Value;
        }

        throw new IndexOutOfRangeException("Unable to find the first number.");
    }

    public static uint getLastNumber(string str)
    {
        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (Char.IsDigit(str[i]))
                return (uint)Char.GetNumericValue(str[i]);

            foreach (var number_word in NUMBER_WORD_VALUES)
                if (str.Substring(0, i + 1).EndsWith(number_word.Key))
                    return number_word.Value;
        }

        throw new IndexOutOfRangeException("Unable to find the first number.");
    }
}
