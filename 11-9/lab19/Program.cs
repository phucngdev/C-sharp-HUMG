using System;

namespace _11_9_21

    
{
    class Program
    {

        class Sinhvien
        {

        }
        static void Main(string[] args)
        {
            var sanpham = new
            {
                Ten = "áo thun",
                Gia = 1000
            };

            Console.WriteLine($"Tên sản phẩm: {sanpham.Ten}, Giá: {sanpham.Gia}");
        }
    }
}
