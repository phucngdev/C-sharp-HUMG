using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humg_25_9_lab_32
{
    class Program {
        static void Main(string[] args) {
           // LinkedList
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(1); // thêm vào đầu
            linkedList.AddLast(2); // thêm vào cuối
            linkedList.AddFirst(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            Console.WriteLine("linkedList: " + string.Join(", ", linkedList));
            linkedList.RemoveFirst();
            Console.WriteLine("sau khi xoá phần tử đầu tiên: " + string.Join(", ", linkedList));
            Console.WriteLine("Tổng số phần tử: " + linkedList.Count);
            // xóa phần tử tại vị trí 2
            linkedList.Remove(2);
            Console.WriteLine("sau khi xoá phần tử tại vị trí 2: " + string.Join(", ", linkedList));
            Console.WriteLine("Tổng số phần tử: " + linkedList.Count);
            // xóa tất cả phần tử trong linked list
            linkedList.Clear();
            Console.WriteLine("sau khi xoá tất cả phần tử: " + string.Join(", ", linkedList));
            Console.WriteLine("Tổng số phần tử: " + linkedList.Count);
            Console.WriteLine("----------------------------------------------------------------");
           
        }
    }
}