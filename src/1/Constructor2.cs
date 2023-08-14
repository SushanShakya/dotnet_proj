namespace program;

public class Constructor2
{
    public int Age;

    public Constructor2(int age)
    {
        Console.WriteLine($"Parameterized constructor called with parameter {age}");
        Age = age;
    }
}