namespace program;

public class Demo
{
    [Obsolete]
    public void DoSomething()
    {
        Console.WriteLine("Obsolete Function");
    }

    public void DoSomething2()
    {
        Console.WriteLine("New Function Implementation");
    }
}