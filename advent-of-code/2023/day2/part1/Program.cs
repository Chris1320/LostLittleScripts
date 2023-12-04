class Program
{
    public static uint[] CUBE_CONFIG = { 12, 13, 14, }; // red, green, blue

    static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: part1 <input_file>");
            return 1;
        }

        uint game_id_sums = 0;
        try
        {
            using (var stream = new StreamReader(args[0]))
            {
                while (!stream.EndOfStream)
                {
                    var line = stream.ReadLine();
                    if (String.IsNullOrWhiteSpace(line))
                        continue;

                    var bag = parseLineToBag(line);
                    if (
                        bag.red <= CUBE_CONFIG[0]
                        && bag.green <= CUBE_CONFIG[1]
                        && bag.blue <= CUBE_CONFIG[2]
                    )
                    {
                        game_id_sums += bag.game_id;
                        Console.WriteLine($"Valid: {bag}");
                    }
                    else
                        Console.WriteLine($"Invalid: {bag}");
                }

                Console.WriteLine($"\nTotal sum of game IDs of valid games: {game_id_sums}");
            }
        }
        catch (Exception e) when (e is FileNotFoundException || e is ArgumentException)
        {
            Console.WriteLine(e.Message);
            return 1;
        }

        return 0;
    }

    public static Bag parseLineToBag(string line)
    {
        var line_contents = line.Split(": ", 2);
        if (line_contents == null)
            throw new ArgumentException("Invalid line");

        var game_id = Convert.ToUInt32(line_contents[0].Split("Game ", 2)[1]);
        var bag = new Bag() { game_id = game_id };

        foreach (var set in line_contents[1].Split("; "))
        {
            foreach (var color in set.Split(", "))
            {
                var properties = color.Split(" ");
                switch (properties[1])
                {
                    case "red":
                        bag.red = Math.Max(bag.red, Convert.ToUInt32(properties[0]) );
                        break;

                    case "green":
                        bag.green = Math.Max(bag.green, Convert.ToUInt32(properties[0]) );
                        break;

                    case "blue":
                        bag.blue = Math.Max(bag.blue, Convert.ToUInt32(properties[0]) );
                        break;

                    default:
                        throw new ArgumentException("Invalid color");
                }
            }
        }

        return bag;
    }
}
