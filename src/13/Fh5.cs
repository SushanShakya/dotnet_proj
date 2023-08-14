namespace program;

public class Fh5 : IFileHandler2
{

    private string? ReadPath;
    private string? WritePath;

    public Fh5()
    {
        ReadPath = "demo.txt";
        WritePath = "fh5.txt";
    }

    public string ReadStuff()
    {
        string? content;
        using (var reader = new FileStream(ReadPath!, FileMode.Open))
        {
            var tmp = new byte[reader.Length];
            reader.Read(tmp, 0, tmp.Length);
            content = System.Text.Encoding.UTF8.GetString(tmp);
        }
        Console.WriteLine($"Read From {ReadPath}");
        return content ?? "";
    }

    public void WriteStuff(string content)
    {
        using (var writer = new FileStream(WritePath!, FileMode.Create))
        {
            var data = System.Text.Encoding.UTF8.GetBytes(content);
            writer.Write(data);
        }
        Console.WriteLine($"Wrote to {WritePath}");
    }
}