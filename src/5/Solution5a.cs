namespace program;

class Solution5a : ISolution
{
    public void Execute()
    {
        var ix = new IntIndexer();
        Console.WriteLine($"Indexed value :{ix[0]}");
        Utility.printStudentInfo("5a");
    }
}