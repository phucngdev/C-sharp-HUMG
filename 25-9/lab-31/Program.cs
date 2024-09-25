using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humg_25_9_lab_31
{
    class Program {
        static void Main(string[] args) {
            var products = new SortedList<string, string> ();
            products.Add("Apple", "Red");
            products.Add("Banana", "Yellow");
            products.Add("Orange", "Orange");
            products.Add("Grape", "Green");
            Console.WriteLine("Original List:");
            foreach (var item in products) {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            // Remove
            products.Remove("Banana");
            Console.WriteLine("\nAfter Removing Banana:");
            foreach (var item in products) {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            // Update 
            products["Apple"] = "Green";
            Console.WriteLine("\nAfter Updating:");
            foreach (var item in products) {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
           

            // truy cập 1 item của danh sách
            Console.WriteLine("\nOrange Color: " + products["Orange"]);

            // kiểm tra key tồn tại
            Console.WriteLine("\nKey tồn tại: " + products.ContainsKey("Apple"));

             // Clear
            products.Clear();
            Console.WriteLine("\nAfter Clearing List:");
            foreach (var item in products) {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}