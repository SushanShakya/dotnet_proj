namespace program;

public class Solution15 : ISolution
{

    private void StatementLambda()
    {
        var tmp = () =>
        {
            Console.WriteLine("I am Statement Lambda");
        };

        tmp();
    }


    private void ExpressionLambda()
    {
        Func<int, int, int> tmp = (a, b) => a + b;
        Console.WriteLine("Executing Expression Lambda");
        Console.WriteLine(tmp(10, 20));
    }

    private void LinqWithLambda()
    {
        var x = new int[] { 1, 2, 3 };
        Console.WriteLine("Executing LINQ with Lambda");
        var s = string.Join(",", x.Where(e => e % 2 == 0));
        Console.WriteLine(s);
    }

    public void Execute()
    {
        StatementLambda();
        ExpressionLambda();
        LinqWithLambda();
        Utility.printStudentInfo("15");
    }
}