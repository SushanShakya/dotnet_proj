namespace program;

public class Solution12 : ISolution
{
    public void Execute()
    {
        var c = new GenClass<int>(10);
        c.Call();
        Utility.printStudentInfo("12");
    }
}