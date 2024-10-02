using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humg_2_10_lab_35
{
    class Program {
        static void Main(string[] args) {
            // Dictionary
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Apple", "Red");
            dictionary.Add("Banana", "Yellow");
            dictionary.Add("Orange", "Orange");
            dictionary.Add("Grape", "Green");
            // lấy giá trị từ key
            Console.WriteLine(dictionary["Apple"]);
            // Truy cập 1 item của dictionary
            Console.WriteLine("\nOrange Color: " + dictionary["Orange"]);
            // xóa phần tử từ key
            dictionary.Remove("Banana");
            // lấy tất cả key-value trong dictionary
            foreach (var item in dictionary) {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            // kiểm tra key có tồn tại trong dictionary
            Console.WriteLine(dictionary.ContainsKey("Apple"));
            // kiểm tra value có tồn tại trong dictionary
            Console.WriteLine(dictionary.ContainsValue("Red"));
            // clear dictionary
            dictionary.Clear();
            Console.WriteLine("After Clearing Dictionary:");
            foreach (var item in dictionary) {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            Console.WriteLine("----------------------------------------------------------------");

            // HashSet
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);
            hashSet.Add(2); // Duplicate won't be added
            Console.WriteLine("HashSet: " + string.Join(", ", hashSet));
            // xóa phần tử từ HashSet
            hashSet.Remove(2);
            Console.WriteLine("After Removing 2 from HashSet:");
            Console.WriteLine("HashSet: " + string.Join(", ", hashSet));
            // kiểm tra xem 1 phần tử có tồn tại trong HashSet
            Console.WriteLine(hashSet.Contains(2));
            // lấy phần tử đầu tiên của HashSet
            Console.WriteLine("First Element: " + hashSet.First());
            // kiểm tra HashSet rỗng (corrected part)
            Console.WriteLine("HashSet Is Empty: " + (hashSet.Count == 0));
            // kiểm tra HashSet đã chứa tất cả các phần tử của 1 list
            List<int> list = new List<int> { 1, 2, 3 };
            Console.WriteLine("Kiểm tra HashSet đã chứa tất cả các phần tử của 1 list: " + hashSet.SetEquals(list));
            // lấy tổng số phần tử trong HashSet
            Console.WriteLine("HashSet Count: " + hashSet.Count);
            // clear HashSet
            hashSet.Clear();
            Console.WriteLine("After Clearing HashSet:");
            Console.WriteLine("HashSet: " + string.Join(", ", hashSet));
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}
