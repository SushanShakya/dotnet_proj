namespace program;

public class Solution3c : ISolution
{
    Tuple<int, int> GetDimension(string a)
    {
        Console.WriteLine($"Enter Dimensions for Matrix {a} :");
        Console.Write("m : ");
        int m = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("n : ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        return new Tuple<int, int>(m, n);
    }

    bool CheckCompatible(Tuple<int, int> a, Tuple<int, int> b)
    {
        return a.Item2 == b.Item1;

    }

    int[,] GetMatrix(int m, int n, string l)
    {
        Console.WriteLine($"Enter Matrix {l}");
        var arr = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Enter element {i},{j} : ");
                arr[i, j] = int.Parse(Console.ReadLine() ?? "0");
            }
        }

        return arr;
    }

    int[,] Multiply(int[,] a, int[,] b, int m1, int n1, int m2, int n2)
    {
        var res = new int[m1, n2];
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < m2; j++)
            {
                int s = 0;
                for (int k = 0; k < n2; k++)
                {
                    s += a[i, k] * b[k, j];
                }
                res[i, j] = s;
            }
        }
        return res;
    }

    void PrintMatrix(int[,] a, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{a[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public void Execute()
    {
        var a = "A";
        var b = "B";
        var dim1 = GetDimension(a);
        var dim2 = GetDimension(b);
        var ok = CheckCompatible(dim1, dim2);
        if (ok)
        {
            var m1 = GetMatrix(dim1.Item1, dim1.Item2, a);
            var m2 = GetMatrix(dim2.Item1, dim2.Item2, b);

            var res = Multiply(m1, m2, dim1.Item1, dim1.Item2, dim2.Item1, dim2.Item2);

            PrintMatrix(res, dim1.Item1, dim2.Item2);
        }
        else
        {
            Console.WriteLine("Multiplication is not possible");
        }
        Utility.printStudentInfo("3c");
    }
}