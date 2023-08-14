namespace program;

public class Fh6 : IFileHandler2
{

    private string? Path;

    public Fh6()
    {
        Path = "fh6.txt";
    }

    public string ReadStuff()
    {
        Console.WriteLine("Enter String :");
        string? data = Console.ReadLine();
        return data ?? "";
    }

    public void WriteStuff(string content)
    {
        using (var writer = new StreamWriter(Path!))
        {
            writer.Write(content);
        }
        Console.WriteLine($"Wrote to {Path}");
    }
}