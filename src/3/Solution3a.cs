namespace program;

public class Solution3a : ISolution
{

    private string[] Arr;
    private int Count;

    public Solution3a(int count)
    {
        Count = count;
        Arr = new string[count];
    }

    public void RequestInput()
    {
        for (int i = 0; i < Count; i++)
        {
            Console.WriteLine($"Enter word #{i + 1}");
            Arr[i] = Console.ReadLine() ?? "";
        }
    }

    private string[] SortAsc()
    {
        string[] tmp = new string[Arr.Length];
        Array.Copy(Arr, tmp, Arr.Length);
        Array.Sort(tmp);
        return tmp;
    }

    private string ArrToString(string[] arr)
    {
        return "[" + string.Join(',', arr) + "]";
    }

    public void DisplayAsc()
    {
        string[] sorted = SortAsc();
        Console.WriteLine(ArrToString(sorted));
    }

    public void Execute()
    {
        RequestInput();
        DisplayAsc();
        Utility.printStudentInfo("3a");
    }
}