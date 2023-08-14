namespace program;

public class Derived : Base
{
    public override void DoSomething()
    {
        Console.WriteLine("Dervied Call");
    }

    public new void Hello()
    {
        Console.WriteLine("Hello Derived");
    }
}