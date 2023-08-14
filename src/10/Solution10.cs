namespace program;

public class Solution10 : ISolution
{

    public delegate int Compute(int a, int b);

    private event EventHandler? SomeEvent;

    public Solution10()
    {
        SomeEvent = HandleEvent;
    }

    private void HandleEvent(object? sender, EventArgs args)
    {
        Console.WriteLine("Event Handled");
    }

    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public void Execute()
    {
        var del = new Compute(Add);
        var res = del.Invoke(10, 20);

        Console.WriteLine("Delegate");
        Console.WriteLine(res);

        del += Multiply;

        Console.WriteLine("Multicast Delegate");
        res = del.Invoke(2, 10);
        Console.WriteLine(res);

        Console.WriteLine("Func Delegate");
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(1, 2));

        Console.WriteLine("Action Delegate");
        Action<int, int> mul = (a, b) =>
        {
            Console.WriteLine($"The multiple : {a * b}");
        };

        Console.WriteLine("Anonymous Function");
        var x = () =>
        {
            Console.WriteLine("Called Anonymous Function");
        };
        x();

        Console.WriteLine("Event Handling");
        SomeEvent?.Invoke(this, EventArgs.Empty);


        Utility.printStudentInfo("10");
    }
}