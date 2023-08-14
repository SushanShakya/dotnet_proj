namespace program;

public class Solution18 : ISolution
{

    private async void DoAsync()
    {
        Console.WriteLine("Start Async Task");
        await Task.Delay(1000);
        Console.WriteLine("Done");
    }


    public void Execute()
    {
        DoAsync();
        Utility.printStudentInfo("18");
    }
}