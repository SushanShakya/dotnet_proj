namespace program;

public class Solution7 : ISolution
{
    public void Execute()
    {
        Base d = new Derived();
        Console.WriteLine("Method Shadowing");
        d.Hello();

        Console.WriteLine("Dynamic Polymorphism");
        d.DoSomething();
        d = new Derived2();
        d.DoSomething();

        Utility.printStudentInfo("7");
    }
}