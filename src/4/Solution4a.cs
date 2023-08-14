namespace program;

public class Solution4a : ISolution
{

    private string? Str;

    public void RequestInput()
    {
        Console.WriteLine("Enter a String :");
        Str = Console.ReadLine();
    }

    public void PrintReverseString()
    {
        if (Str == null) return;
        Console.WriteLine("Reverse String: ");
        int l = Str.Length;
        for (int i = 0; i < l; i++)
        {
            Console.Write(Str[l - 1 - i]);
        }
        Console.WriteLine("");
    }

    private Dictionary<char, int> GatherOccurence(string str)
    {
        var map = new Dictionary<char, int>();
        var tmp = str.ToLower();
        for (int i = 0; i < tmp.Length; i++)
        {
            var key = tmp[i];
            bool contains = map.ContainsKey(key);
            if (contains)
            {
                map[key] += 1;
            }
            else
            {
                map[key] = 1;
            }
        }
        return map;
    }

    public void PrintOccurence()
    {
        if (Str == null) return;
        var occurences = GatherOccurence(Str);
        Console.WriteLine("Occurences");
        foreach (var key in occurences.Keys)
        {
            Console.WriteLine($"{key} : {occurences[key]}");
        }
    }

    public void Execute()
    {
        RequestInput();
        PrintReverseString();
        PrintOccurence();
        Utility.printStudentInfo("4a");
    }
}
