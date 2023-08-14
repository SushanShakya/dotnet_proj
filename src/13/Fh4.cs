namespace program;

public class Fh4 : IFileHandler
{

    private string? Path;

    public Fh4()
    {
        Path = "fh1.bin";
    }

    public void WriteStuff()
    {
        using (var writer = new BinaryWriter(File.Open(Path!, FileMode.Create)))
        {
            writer.Write(10);
            writer.Write("Hello");
        }
        Console.WriteLine("Wrote Lines");
    }

    public void ReadStuff()
    {
        using (var reader = new BinaryReader(File.Open(Path!, FileMode.Open)))
        {
            var integerVal = reader.ReadInt16();
            var strVal = reader.ReadString();

            Console.WriteLine($"Read Values : {integerVal} and {strVal}");
        }
    }
}