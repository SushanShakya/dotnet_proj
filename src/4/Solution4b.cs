namespace program;

public class Solution4b : ISolution
{
    private string? Str;

    public void RequestInput()
    {
        Console.WriteLine("Enter a String :");
        Str = Console.ReadLine();
    }

    private int CountCharacters()
    {
        if (Str == null) return -1;
        return Enumerable.Aggregate(Str.Where((e) => e != ' '), 0, (a, b) => a + 1);
    }

    private string[] SplitToWords()
    {
        if (Str == null) return new string[0];
        return Str.Split(' ').Select(e => e.ToLower()).ToArray();
    }

    private int CountWords()
    {
        var words = SplitToWords();
        return words.Length;
    }

    private Dictionary<string, int> GatherOccurence()
    {
        var words = SplitToWords();
        var map = new Dictionary<string, int>();
        foreach (var word in words)
        {
            var present = map.ContainsKey(word);
            if (present)
            {
                map[word] += 1;
            }
            else
            {
                map[word] = 1;
            }
        }
        return map;
    }

    public void PrintTotalCharacters()
    {
        var count = CountCharacters();
        Console.WriteLine($"Total Characters : {count}");
    }

    public void PrintTotalWords()
    {
        var count = CountWords();
        Console.WriteLine($"Total Words : {count}");
    }

    public void DisplayOccurrences()
    {
        var occurences = GatherOccurence();
        Console.WriteLine("Occurences :");
        foreach (var key in occurences.Keys)
        {
            Console.WriteLine($"{key} : {occurences[key]}");
        }
    }

    public void Execute()
    {
        RequestInput();
        PrintTotalCharacters();
        PrintTotalWords();
        DisplayOccurrences();
        Utility.printStudentInfo("4a");
    }
}