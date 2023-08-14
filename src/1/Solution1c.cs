namespace program;

public class Solution1c : ISolution
{
    public void Execute()
    {
        Constructor3 c3_1 = new Constructor3();
        Constructor3 c3 = new Constructor3(c3_1);
        Utility.printStudentInfo("1c");
    }
}