namespace program;

public class Solution14 : ISolution
{
    public void Execute()
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        var evens = numbers.Where(e => e % 2 == 0);

        Console.WriteLine($"Filtered numbers : {string.Join(",", evens)}");

        Utility.printStudentInfo("14");
    }
}
