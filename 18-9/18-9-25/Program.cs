using System;
using System.Linq;
using LibInt;

namespace _18_9_25
{
   
    public static class StaticClass
    {
        // phương thức mở rộng cho chuỗi 
        public static void Print(this string s, ConsoleColor c)
        { 
            Console.ForegroundColor = c; 
            Console.WriteLine(s);
            Console.ResetColor();
        }

        // phương thức mở rộng cho int
        public static void Print(this int s, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            string hello = "Hello các bạn";
            hello.Print(ConsoleColor.Blue);

            2.Print(ConsoleColor.Red);

            Console.WriteLine(3.Pow());
            Console.WriteLine(4.Sqrt());

        }
    }
}

 

