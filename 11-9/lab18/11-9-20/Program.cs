namespace _11_9_20;

class Program
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T c = a;
        a = b;
        b = c;
    }

    static void Main(string[] args)
    {
        int a = 4;
        int b = 10;
        Console.WriteLine($"a: {a}, b: {b}");
        Swap<int>(ref a, ref b);
        Console.WriteLine($"a: {a}, b: {b}");

    }
}

