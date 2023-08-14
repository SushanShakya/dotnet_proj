namespace program;

public class MyAttrib : Attribute
{
    public string? Message;

    public MyAttrib(string message)
    {
        Message = message;
    }
}