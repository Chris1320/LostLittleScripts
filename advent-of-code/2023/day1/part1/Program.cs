class Program
{
    public static int Main(string[] args)
    {
        int sum = 0;
        int lines = 0;
        using (var reader = new StreamReader("../list.txt"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string result = String.Empty;

                if (line != null)
                {
                    char[] row_chars = line.ToCharArray();
                    foreach (var c in row_chars)
                        if (Char.IsNumber(c))
                        {
                            result += Convert.ToString(c);
                            break;
                        }

                    Array.Reverse(row_chars);
                    foreach (var c in row_chars)
                        if (Char.IsNumber(c))
                        {
                            result += Convert.ToString(c);
                            break;
                        }

                    if (!String.IsNullOrEmpty(result))
                        sum += Convert.ToInt32(result);

                    lines++;
                }
            }
        }

        Console.WriteLine($"Processed {lines} lines.");
        Console.WriteLine($"Total: {sum}");
        return 0;
    }
}
