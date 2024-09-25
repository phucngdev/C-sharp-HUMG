using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humg_25_9_lab_30
{
    class Program {
        static void Main(string[] args) {
            List<int> list = new List<int>() {1, 2, 3, 4, 5, 6, 7};
            // truy cập phần tử 
            Console.WriteLine(list[5]);
            // thêm phần tử vào cuối list
            list.Add(10);
            // xóa phần tử tại vị trí 2
            list.RemoveAt(2);
            // thêm phần tử vào vị trí 3
            list.Insert(3, 12);
           
            // thêm phần tử vào vị trí đầu của list
            list.Insert(0, 1);
            // lấy phần tử đầu tiên của list
            Console.WriteLine(list.First());
            // lấy phần tử cuối
            Console.WriteLine(list.Last());
            // lấy tổng của list
            Console.WriteLine(list.Sum());
            // lấy tích của list
            Console.WriteLine(list.Aggregate((x, y) => x * y));
            // lấy trung
            // sửa phần tử tại vị trí 3
            list[3] = 15;
            // tìm kiếm phần tử
            Console.WriteLine(list.IndexOf(15));
            // sắp xếp list theo thứ tự tăng dần
            list.Sort();
            // in ra
            Console.WriteLine("list.Sort: " + string.Join(", ", list));
            // sắp xếp list theo thứ tự giảm dần
            list.Sort((x, y) => y.CompareTo(x));
            // in ra
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            // lấy phần tử đầu tiên của list
            Console.WriteLine(list.First());
            // lấy phần tử cuối
            Console.WriteLine(list.Last());
            // lấy tổng của list
            Console.WriteLine(list.Sum());
            // lấy tích của list
            Console.WriteLine(list.Aggregate((x, y) => x * y));
            // tìm giá trị lớn nhất trong list
            Console.WriteLine(list.Max());
            // tìm giá trị nhỏ nhất trong list
            Console.WriteLine(list.Min());
            // tổng số phần tử
            Console.WriteLine(list.Count);
            // tìm phần tử đã xác định trong list
            Console.WriteLine(list.Contains(6));
             // xóa tất cả phần tử
            list.Clear();
        }
    }
}