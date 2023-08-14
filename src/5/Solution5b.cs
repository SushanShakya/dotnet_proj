namespace program;

public class Solution5b : ISolution
{
    public void Execute()
    {
        var ix = new StringIndexer();
        Console.WriteLine($"Indexed value : {ix["apple"]}");
        Utility.printStudentInfo("5b");
    }
}