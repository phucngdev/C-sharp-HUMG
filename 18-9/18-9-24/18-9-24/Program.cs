using System; 

namespace _18_9_24
{
    // tạo delegate 
    public delegate void HandleChangeInput(int x);

    // tạo lớp 
    class User
    {
        public HandleChangeInput handleChangeInput { set; get; }

        public void ChangeInput()
        {
            Console.Write("nhập vào số nguyên: ");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            handleChangeInput?.Invoke(x);
        }
    }

    class MathSqrt
    {
        public void Sub(User user)
        {
            // Gán delegate để xử lý sự kiện
            user.handleChangeInput = FuncMathSqrl;
        }

        public void FuncMathSqrl(int x) {
            Console.WriteLine($"can bac 2 cua {x} = {Math.Sqrt(x)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // lớp user phát đi sự kiện 
            User user = new User();

            // lớp nhận sự 
            MathSqrt mathSqrt = new MathSqrt();

            // Đăng ký sự kiện xử lý cho user
            mathSqrt.Sub(user);

            // Thực hiện nhập và tính toán
            user.ChangeInput();

        }
    }
}



