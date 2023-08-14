namespace program;

public class MultiChild : AbsData, IAnimal
{
    public override void Run()
    {
        Console.WriteLine("Walking");
    }

    public void Walk()
    {
        Console.WriteLine("Walking");
    }
}