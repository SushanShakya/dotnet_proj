using System.Collections;

namespace program;

public class Solution11 : ISolution
{
    public void Execute()
    {
        var stack = new Stack();
        Console.WriteLine("Non-Generic Collection");
        stack.Push(1);
        stack.Push("b");
        Console.WriteLine(string.Join(",", stack.ToArray()));

        List<int> col2 = new List<int> { 1, 2, 3 };

        Console.WriteLine("Generic Collection");
        Console.WriteLine(string.Join(",", col2));

        Utility.printStudentInfo("11");
    }
}
