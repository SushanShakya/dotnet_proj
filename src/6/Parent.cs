namespace program;

public class Parent
{
    protected int age;

    public Parent()
    {
        Console.WriteLine("Base Constructor");
        age = 10;
    }

    protected void DoSomething()
    {
        Console.WriteLine("Hello World !");
    }
}
