namespace program;

public class Solution2 : ISolution
{
    public void Execute()
    {
        Person p = new Person();
        Console.WriteLine("Demonstrate Property Age");
        p.Age = 10;
        Console.WriteLine(p.Age);
        Utility.printStudentInfo("2");
    }
}