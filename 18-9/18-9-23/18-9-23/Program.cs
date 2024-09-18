using System;
using System.Linq;

namespace _18_9_23;

// lambda 
class Program
{
    static void Main(string[] args)
    {
        // 
        Action<string> action;
        action = (s) => Console.WriteLine(s);
        action?.Invoke("Hello lambda");

        Func<int, int, int> action2;
        action2 = (a, b) =>
        {
            return a + b;
        };
        var kq = action2(1, 2);
        Console.WriteLine($"ket qua action2: {kq}");
        Console.WriteLine(action2.Invoke(2, 3));
        
    }
}

