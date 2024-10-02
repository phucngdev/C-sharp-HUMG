using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humg_2_10_lab_37
{
    class Program {
        static void Main(string[] args) {
            // LINQ
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            // lấy số chẵn, sắp sếp giảm dần
            var result = numbers.Where(x => x % 2 == 0).OrderByDescending(x => x);
            foreach (var item in result) {
                Console.WriteLine(item);
            }
            // Grouping
            // nhóm sỗ chẵn và lẻ, đếm số số lượng trong mỗi nhóm
            var groupedResult = numbers.GroupBy(x => x % 2 == 0).Select(group => new { IsEven = group.Key, Count = group.Count() });
            foreach (var item in groupedResult) {
                Console.WriteLine($"Is Even: {item.IsEven}, Count: {item.Count}");
            }
            // join 2 list
            List<string> names = new List<string> { "John", "Alice", "Bob" };
            List<int> ages = new List<int> { 25, 30, 28 };
            var joinedResult = names.Zip(ages, (name, age) => new { Name = name, Age = age });
            foreach (var item in joinedResult) {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
            }

            
        }
    }
}
