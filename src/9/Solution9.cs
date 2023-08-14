namespace program;

public class Solution9 : ISolution
{
    public void Execute()
    {

        var d = new Dog();
        Console.WriteLine("Struct");
        Console.WriteLine(d.CellType);

        Console.WriteLine("Enum");
        Console.WriteLine(Cell.plant);

        Console.WriteLine("Partial Class");
        var p = new PartialC();
        p.Do();
        p.Run();

        Utility.printStudentInfo("9");

    }
}