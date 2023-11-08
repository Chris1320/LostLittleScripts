class Processor
{
    public string filepath;
    private string? content;
    private const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    public Processor(string filepath)
    {
        this.filepath = filepath;
        this.ReadFile();
    }

    private void ReadFile()
    {
        using (var stream = new StreamReader(this.filepath))
            this.content = stream.ReadToEnd();
    }

    public int GetCharCount()
    {
        if (this.content != null)
        {
            int n = 0;
            for (int i = 0; i < this.content.Length; i++)
                if (Processor.chars.Contains(this.content[i]))
                    n++;
            return n;
        }
        else
            throw new Exception("Failed to read the file.");
    }

    public int GetWordCound()
    {
        if (this.content != null)
        {
            int n = 0;
            n = this.content.Split(" ").Length; // FIXME: I know this is incorrect.
            return n;
        }
        else
            throw new Exception("Failed to read the file.");
    }
}
