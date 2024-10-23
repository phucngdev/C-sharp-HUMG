using System;
using System.Threading.Tasks;

namespace MultiThreadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bắt đầu chương trình...");

            // Sử dụng Parallel.For để thực hiện một công việc lặp đi lặp lại (loop) với các luồng song song.
            // Giả sử cần in số từ 0 đến 9, thay vì in tuần tự, chúng ta sẽ sử dụng Parallel để tăng tốc độ.
            Parallel.For(0, 10, i =>
            {
                // Hiển thị luồng hiện tại và giá trị của i
                Console.WriteLine($"Parallel.For - Luồng: {Task.CurrentId}, Giá trị i = {i}");
            });

            // Sử dụng Parallel.ForEach để duyệt qua một mảng và xử lý các phần tử song song.
            string[] names = { "Alice", "Bob", "Charlie", "Dave", "Eve" };

            // Parallel.ForEach sẽ chạy song song và xử lý từng tên trong mảng names.
            Parallel.ForEach(names, name =>
            {
                // In ra tên và luồng hiện tại đang thực hiện công việc đó
                Console.WriteLine($"Parallel.ForEach - Luồng: {Task.CurrentId}, Tên = {name}");
            });

            // Sử dụng Parallel.Invoke để chạy nhiều tác vụ song song.
            // Chúng ta sẽ định nghĩa các hành động khác nhau và để Parallel.Invoke thực thi chúng song song.
            Parallel.Invoke(
                () => DoTask("Task 1", 2000), // Chạy tác vụ 1 (mất 2 giây)
                () => DoTask("Task 2", 1000), // Chạy tác vụ 2 (mất 1 giây)
                () => DoTask("Task 3", 3000)  // Chạy tác vụ 3 (mất 3 giây)
            );

            Console.WriteLine("Kết thúc chương trình.");
        }

        // Phương thức DoTask mô phỏng một tác vụ mất thời gian.
        static void DoTask(string taskName, int delay)
        {
            Console.WriteLine($"{taskName} bắt đầu thực thi trên luồng: {Task.CurrentId}");
            Task.Delay(delay).Wait(); // Chờ một khoảng thời gian (giả lập công việc mất thời gian)
            Console.WriteLine($"{taskName} đã hoàn thành.");
        }
    }
}
