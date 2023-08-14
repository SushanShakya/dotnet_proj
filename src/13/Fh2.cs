namespace program;

public class Fh2 : IFileHandler
{

    private string? Path;

    public Fh2()
    {
        Path = "fh2.txt";
    }

    public void WriteStuff()
    {
        using (var writer = new FileStream(Path!, FileMode.Create))
        {
            writer.Write(System.Text.Encoding.UTF8.GetBytes("Content"));
        }
        Console.WriteLine("Wrote Lines");
    }

    public void ReadStuff()
    {
        using (var reader = new FileStream(Path!, FileMode.Open))
        {
            var data = new byte[reader.Length];

            reader.Read(data, 0, data.Length);

            string content = System.Text.Encoding.UTF8.GetString(data);

            Console.WriteLine($"Read Value:\n{content} ");
        }
    }
}