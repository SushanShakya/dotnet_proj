namespace program;

public class StringIndexer
{
    public int this[string a]
    {
        get
        {
            if (a == "apple")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}