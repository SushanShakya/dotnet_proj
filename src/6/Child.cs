namespace program;

public class Child : Parent
{

    public Child() : base()
    {
    }

    public void DelegateWork()
    {
        Console.WriteLine("Calling Parent Method");
        base.DoSomething();
    }

    public void CallBaseField()
    {
        Console.WriteLine("Calling Base Field");
        Console.WriteLine(base.age);
    }
}