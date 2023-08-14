namespace program;

public class GenClass<T>
{
    public T? Value;

    public GenClass(T value)
    {
        Value = value;
    }

    public T Call()
    {
        Console.WriteLine("Calling Generic Method from Generic Class with Generic Field.");
        Console.WriteLine($"Value : {Value}");
        return Value!;
    }
}