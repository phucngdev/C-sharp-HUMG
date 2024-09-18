using System;

namespace CS_Delegate
{
    // khai báo
    public delegate void ShowLog(string message);

    class Program
    {
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Info: {0}", s));
            Console.ResetColor();
        }

        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Waring: {0}", s));
            Console.ResetColor();
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            ShowLog log = null;
            // Nối thêm một phương thức vào delegate với +=
            log += Info;
            log += Warning;
            // 2 cách gọi
            if (log != null)
                log("Hello");

            log?.Invoke("Hello với Invoke");

            // action
            Action<string> action;
            action = Info;

            action?.Invoke("Action hello");

            // func
            // khai báo | tham số, kiểu trả về ở cuối 
            Func<int, int, int> tinhtong;
            tinhtong = Sum;                     

            var ketqua = tinhtong(1, 2);
            Console.WriteLine(ketqua);

        }
    }
}