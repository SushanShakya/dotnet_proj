
using program;

public class MainProgram
{
    static ISolution GetSolution()
    {
        return new Solution1e();
    }
    public static void Main()
    {
        ISolution solution = GetSolution();

        solution.Execute();
    }
}