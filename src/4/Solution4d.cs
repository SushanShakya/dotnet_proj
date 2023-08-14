namespace program;

public class Solution4d : ISolution
{

    private string? Str;

    private void GetInput()
    {
        Console.WriteLine("Enter String :");
        Str = Console.ReadLine();
    }

    private string ExtractSubstringBeforeFirstComma()
    {
        var tmp = Str!.Split(',');
        if (tmp.Length == 0)
        {
            return "";
        }
        return tmp[0];
    }

    public void Execute()
    {
        GetInput();
        var tmp = ExtractSubstringBeforeFirstComma();
        Console.WriteLine($"Uppercased : {tmp.ToUpper()}");
        Utility.printStudentInfo("4d");
    }
}