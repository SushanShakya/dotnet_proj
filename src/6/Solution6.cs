namespace program;

public class Solution6 : ISolution
{
    public void Execute()
    {
        Child child = new Child();
        child.CallBaseField();
        child.DelegateWork();
        Utility.printStudentInfo("6");
    }
}