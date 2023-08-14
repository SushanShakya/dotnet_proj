namespace program;

public class Solution8 : ISolution
{
    public void Execute()
    {
        var c = new MultiChild();
        c.Do();
        c.Run();

        Utility.printStudentInfo("8");
    }
}