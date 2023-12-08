class Program
{
    static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: part1 <input_file>");
            return 1;
        }

        try
        {
            uint sum = 0;
            var lines = File.ReadAllLines(args[0]); // read the whole file

            for (int row = 0; row < lines.Length; row++)
            {
                bool found_num;
                bool prev_found_num = false;
                int[] num_coords = new int[2];

                for (int col = 0; col < lines[row].Length; col++)
                {
                    found_num = Char.IsDigit(lines[row][col]);

                    if (found_num) // transition from symbol to digit
                    {
                        if (prev_found_num != found_num) // transition from symbol to digit
                            num_coords[0] = col; // mark col idx as start of the number
                    }
                    else
                    {
                        // FIXME: It does not count numbers at the end of line.
                        if (prev_found_num != found_num) // transition from digit to symbol
                        {
                            num_coords[1] = col - 1;

                            // check the surrounding area
                            for (int y = row - 1; y <= row + 1; y++)
                            {
                                if (y < 0 || y >= lines.Length)
                                    continue;

                                for (int x = num_coords[0] - 1; x <= num_coords[1] + 1; x++)
                                {
                                    if (x < 0 || x >= lines[y].Length)
                                        continue;

                                    // immediately add the number if there
                                    // is a symbol in the surrounding area.
                                    if (
                                        !Char.IsDigit(lines[y][x])
                                        && lines[y][x].CompareTo('.') != 0
                                    )
                                        sum += Convert.ToUInt32(
                                            lines[row].Substring(
                                                num_coords[0],
                                                num_coords[1] - num_coords[0] + 1
                                            )
                                        );
                                }
                            }
                        }
                    }

                    prev_found_num = found_num;
                }
            }

            Console.WriteLine($"Total: {sum}");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
            return 1;
        }

        return 0;
    }
}
