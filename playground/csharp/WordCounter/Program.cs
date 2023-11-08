namespace WordCounter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{Info.NAME} v{string.Join(".", Info.VERSION)}\n");

        if (args.Length < 1)
        {
            string exe_name;
            if (System.Environment.ProcessPath != null)
                exe_name = Path.GetFileName(System.Environment.ProcessPath);
            else
                exe_name = "WordCounter";

            Console.WriteLine($"Usage: {exe_name} <filepaths>");
            return;
        }

        Processor[] file_stats = new Processor[args.Length];
        for (int i = 0; i < args.Length; i++)
        {
            string filepath = args[i];
            Console.WriteLine($"Processing {i + 1} of {args.Length}: {filepath}");
            try
            {
                file_stats[i] = new Processor(filepath);
            }
            catch (Exception e)
            {
                Console.WriteLine($"[ERROR] {e.Message}");
            }
        }

        Console.WriteLine("\nResults:");
        for (int i = 0; i < args.Length; i++)
        {
            if (file_stats[i] != null)
            {
                Processor file_stat = file_stats[i];
                Console.WriteLine($"{file_stat.filepath}:");
                Console.WriteLine($"\t{file_stat.GetCharCount()} characters");
                Console.WriteLine($"\t{file_stat.GetWordCound()} words");
            }
        }
    }
}
