using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humg_25_9_lab_32
{
    class Program {
        static void Main(string[] args) {
           // queue FIFO
           // khoi tạo
            Queue<int> queue = new Queue<int>();
            // thêm vào hàng đợi
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("queue: " + string.Join(", ", queue));
            queue.Dequeue(); // loại bỏ phần tử đầu tiên 
            Console.WriteLine("After Dequeue: " + string.Join(", ", queue));
            Console.WriteLine("----------------------------------------------------------------");
            // stack FILO
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("stack: " + string.Join(", ", stack));
            // đọc và loại bỏ phần tử đầu tiên
            Console.WriteLine("pop: " + stack.Pop());
            Console.WriteLine("sau pop: " + string.Join(", ", stack));
            // trả về phần tử đỉnh
            Console.WriteLine("Peek: " + stack.Peek());
            Console.WriteLine("sau Peek: " + string.Join(", ", stack));
            Console.WriteLine("Tổng số phần tử: " + stack.Count());
            // 	kiểm tra một phần tử có trong stack hay không
            Console.WriteLine("Contain 2: " + stack.Contains(2));
            //  xóa tất cả phần tử trong stack
            stack.Clear();
            Console.WriteLine("After Clear: " + string.Join(", ", stack));
            Console.WriteLine("----------------------------------------------------------------");
            // // linked list
            // LinkedList<int> linkedList = new LinkedList<int>();
            // linkedList.AddFirst(1);
            // linkedList.AddFirst(2);
            // linkedList.AddFirst(3);
            // Console.WriteLine("linkedList: " + string.Join(", ", linkedList));
            // linkedList.RemoveFirst();
            // Console.WriteLine("After RemoveFirst: " + string.Join(", ", linkedList));
            // Console.WriteLine("----------------------------------------------------------------");
            // // hash set
            // HashSet<int> hashSet = new HashSet<int>();
            // hashSet.Add(1);
            // hashSet.Add
            Console.WriteLine("----------------------------------------------------------------");
            // // dictionary
            // Dictionary<string, int> dict = new Dictionary<string, int>();
            // dict.Add("One", 1);
            // dict.Add("Two", 2);
            // dict.Add("Three", 3);
        }
    }
}