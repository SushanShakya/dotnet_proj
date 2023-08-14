namespace program;

public class Solution16 : ISolution
{

    private void HandleException()
    {
        try
        {
            Console.WriteLine("Trying");
            var a = 0;
            var x = 10 / a;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Caught Exception");
        }
        finally
        {
            Console.WriteLine("End");
        }
    }

    private void UseThrow()
    {
        try
        {
            throw new Exception("error");
        }
        catch (Exception)
        {
            Console.WriteLine("Caught Exception");
        }
    }

    private void CustomExceptions()
    {
        try
        {
            throw new CustomException("Sorry");
        }
        catch (CustomException e)
        {
            Console.WriteLine($"Caught Exception : {e.Message}");
        }

    }

    public void Execute()
    {
        HandleException();
        UseThrow();
        CustomExceptions();
        Utility.printStudentInfo("16");
    }
}