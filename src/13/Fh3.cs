namespace program;

public class Fh3 : IFileHandler
{

    private string? Path;

    public Fh3()
    {
        Path = "fh3.txt";
    }

    public void WriteStuff()
    {
        using (TextWriter writer = new StreamWriter(Path!))
        {
            writer.WriteLine("Hello");
        }
        Console.WriteLine("Wrote Lines");
    }

    public void ReadStuff()
    {
        using (TextReader reader = new StreamReader(Path!))
        {
            string? line;
            Console.WriteLine($"Read Value :");
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}