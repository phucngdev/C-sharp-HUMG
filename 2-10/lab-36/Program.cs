using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humg_2_10_lab_36
{
    class Program {
        static void Main(string[] args) {
            // ObservableCollection
            ObservableCollection<string> observableCollection = new ObservableCollection<string>();
            observableCollection.Add("Apple");
            observableCollection.Add("Banana");
            observableCollection.Add("Orange");
            // thêm 1 item vào đầu
            observableCollection.Insert(0, "Grape");
            // xóa 1 item
            observableCollection.Remove("Banana");
            // in item trong ObservableCollection
            foreach (var item in observableCollection) {
                Console.WriteLine(item);
            }
            // kiểm tra xem 1 item có tồn tại trong ObservableCollection
            Console.WriteLine(observableCollection.Contains("Apple"));
            // kiểm tra ObservableCollection rỗng
            Console.WriteLine(observableCollection.Count == 0);
            // clear ObservableCollection
            observableCollection.Clear();
            Console.WriteLine("After Clearing ObservableCollection:");
            foreach (var item in observableCollection) {
                Console.WriteLine(item)
            }
            
        }
    }
}
