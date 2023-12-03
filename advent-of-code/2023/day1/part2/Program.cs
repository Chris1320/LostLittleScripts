class Program
{
    public static int Main(string[] args)
    {
        int sum = 0; // The total sum of the calibration values.
        int lines_processed = 0;
        var number_word_values = new Dictionary<string, string>()
        {
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" },
            { "six", "6" },
            { "seven", "7" },
            { "eight", "8" },
            { "nine", "9" }
        };

        using (var reader = new StreamReader("../list.txt"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string result = String.Empty;

                if (!String.IsNullOrWhiteSpace(line))
                {
                    var reversed_line = ReverseString(line);
                    int first_idx = line.Length;
                    int last_idx = line.Length;

                    Console.WriteLine($"Line #{++lines_processed}: {line}");
                    // Step 1: Try to get the first and last number WORDs.
                    foreach (var number_word in number_word_values.Keys)
                    {
                        // try to get the index of the first number word occurrence.
                        if (line.IndexOf(number_word) != -1)
                            first_idx = Math.Min(line.IndexOf(number_word), first_idx);

                        // try to get the index of the last number word occurrence
                        if (reversed_line.IndexOf(ReverseString(number_word)) != -1)
                            last_idx = Math.Min(
                                reversed_line.IndexOf(ReverseString(number_word)),
                                last_idx
                            );
                    }
                    // Step 2: Try to get the first and last DIGITS.
                    for (int i = 1; i <= 9; i++)
                    {
                        string digit = Convert.ToString(i);
                        // try to get the index of the first digit occurrence.
                        if (line.IndexOf(digit) != -1)
                            first_idx = Math.Min(line.IndexOf(digit), first_idx);

                        // try to get the index of the last number word occurrence
                        if (reversed_line.IndexOf(ReverseString(digit)) != -1)
                            last_idx = Math.Min(
                                reversed_line.IndexOf(ReverseString(digit)),
                                last_idx
                            );
                    }

                    // append the values to result.
                    if (char.IsDigit(line[first_idx]))
                        result += line[first_idx];
                    else
                        foreach (var number in number_word_values.Keys)
                            if (line.Substring(first_idx).StartsWith(number))
                                result += number_word_values[number];

                    if (char.IsDigit(reversed_line[last_idx]))
                        result += reversed_line[last_idx];
                    else
                        foreach (var number in number_word_values.Keys)
                            if (reversed_line.Substring(last_idx).StartsWith(ReverseString(number)))
                                result += number_word_values[number];

                    sum += Convert.ToInt32(result);
                }
            }
        }

        Console.WriteLine($"Processed {lines_processed} lines.");
        Console.WriteLine($"Total: {sum}");
        return 0;
    }

    public static string ReverseString(string s)
    {
        var s_arr = s.ToCharArray();
        Array.Reverse(s_arr);
        return new string(s_arr);
    }
}
