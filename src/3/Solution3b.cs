namespace program;

public class Solution3b : ISolution
{
    public void Execute()
    {
        int[][] arr = new int[2][];
        arr[0] = new int[] { 1, 2 };
        arr[1] = new int[] { 3, 2 };

        Console.WriteLine("Jagged Array Elements :");
        foreach (var i in arr)
        {
            var a = $"{{{string.Join(",", i)}}}";
            Console.WriteLine(a);
        }
        Utility.printStudentInfo("3b");

    }
}