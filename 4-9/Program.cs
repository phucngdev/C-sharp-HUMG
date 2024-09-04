using System;

namespace CS_4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = MethodMath.Sum(1, 2);
            var b = MethodMath.Subtract(5, 3);
            Console.WriteLine($"Sum: {a}, Difference: {b}");
            Console.WriteLine("================================");
            var student = new Student("Hoàng");
            student.Study();
            student.SetAge(18);
            Console.WriteLine("================================");
        }
    }
}