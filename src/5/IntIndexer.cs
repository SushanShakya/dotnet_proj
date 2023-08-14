namespace program;

public class IntIndexer
{
    private int a;
    private int b;

    public IntIndexer()
    {
        a = 10;
        b = 20;
    }

    public int this[int index]
    {
        get
        {
            if (index == 0) return a;
            return b;
        }
        set
        {
            if (index == 0)
            {
                a = value;
            }
            else
            {
                b = value;
            }
        }
    }
}