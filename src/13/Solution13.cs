namespace program;

public class Solution13 : ISolution
{

    private object[] handlers;
    public Solution13()
    {
        handlers = new object[] {
            new Fh1(),
            new Fh2(),
            new Fh3(),
            new Fh5(),
            new Fh6(),
        };
    }

    public void Execute()
    {
        foreach (var handler in handlers!)
        {
            Console.WriteLine($"Calling class {handler.GetType().Name}");
            if (handler is IFileHandler)
            {
                var tmp = ((IFileHandler)handler);
                tmp.WriteStuff();
                tmp.ReadStuff();
            }
            if (handler is IFileHandler2)
            {
                var tmp = ((IFileHandler2)handler);
                var content = tmp.ReadStuff();
                tmp.WriteStuff(content);
            }
            Console.WriteLine("---- End\n");
        }

        Utility.printStudentInfo("13");
    }
}
