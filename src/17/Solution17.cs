namespace program;

public class Solution17 : ISolution
{
    [MyAttrib("Hello")]
    [Obsolete]
    public void Execute()
    {
        var x = new Demo();
        /// Compiler Shows obsolete warning
        x.DoSomething();
        Utility.printStudentInfo("17");
    }
}