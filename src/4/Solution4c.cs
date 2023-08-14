namespace program;

public class Solution4c : ISolution
{

    string? Str;
    string? ParticularString;

    public Solution4c()
    {
        ParticularString = "hell";
    }

    void RequestInput()
    {
        Console.WriteLine("Enter String :");
        Str = Console.ReadLine();
    }

    void DoesStartWith()
    {
        if (Str!.StartsWith(ParticularString!))
        {
            Console.WriteLine($"String starts with {ParticularString}");
        }
    }

    void DoesEndWith()
    {
        if (Str!.EndsWith(ParticularString!))
        {
            Console.WriteLine($"String ends with {ParticularString}");
        }
    }

    public void Execute()
    {
        RequestInput();
        DoesStartWith();
        DoesEndWith();
        Utility.printStudentInfo("4c");
    }
}