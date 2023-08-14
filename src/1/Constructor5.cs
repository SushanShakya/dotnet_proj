namespace program;

public class Constructor5
{
    static Constructor5? Instance;

    private Constructor5()
    {
        Console.WriteLine("Private Constuctor Called !");
    }

    public static Constructor5 GetInstance()
    {
        if (Instance == null)
        {
            Instance = new Constructor5();
        }
        return Instance;
    }
    
}