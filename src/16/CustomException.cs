namespace program;

public class CustomException : Exception
{
    public new string Message;

    public CustomException(string message)
    {
        Message = message;
    }
}