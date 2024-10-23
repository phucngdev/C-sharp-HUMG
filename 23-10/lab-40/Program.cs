using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humg_23_10_lab_40
{
    class Program {

        static void Main(string[] args) {
            // Type
            int[] a = {1,2,3};
            // GetType
            Type type2 = a.GetType();
            // GetFullName
            Console.WriteLine("FullName of int: " + type2.FullName);
            // GetNamespace
            Console.WriteLine("Namespace of int: " + type2.Namespace);
            // GetMethods // các phương thức
            Console.WriteLine("GetMethods ----------------------");
            type2.GetMethods().ToList().ForEach(
                (m) => {
                    Console.WriteLine(m.Name);
                }
            );
            // GetFields // các trường dữ liệu
            Console.WriteLine("GetFields ----------------------");
            type2.GetFields().ToList().ForEach(
                (m) => {
                    Console.WriteLine(m.Name);
                }
            );
            // GetProperties // các thuộc tính
            Console.WriteLine("GetProperties ----------------------");
            type2.GetProperties().ToList().ForEach(
                (m) => {
                    Console.WriteLine(m.Name);
                }
            );
            // GetEvents // các sự kiện
            Console.WriteLine("GetEvents ----------------------");
            type2.GetEvents().ToList().ForEach(
                (m) => {
                    Console.WriteLine(m.Name);
                }
            );

            // Attribute
           // Khởi tạo đối tượng User
            var user = new User();

            // In ra các thông tin của lớp User
            // Đọc các Attribute của lớp
            Console.WriteLine("Attributes of the class:");
            foreach (Attribute attr in user.GetType().GetCustomAttributes(false))
            {
                MotaAttribute mota = attr as MotaAttribute;
                if (mota != null)
                {
                    Console.WriteLine($"{user.GetType().Name}: {mota.Description}");
                }
            }

            // Đọc Attribute của từng thuộc tính lớp
            Console.WriteLine("\nAttributes of the properties:");
            foreach (var property in user.GetType().GetProperties())
            {
                foreach (Attribute attr in property.GetCustomAttributes(false))
                {
                    MotaAttribute mota = attr as MotaAttribute;
                    if (mota != null)
                    {
                        Console.WriteLine($"{property.Name}: {mota.Description}");
                    }
                }
            }

            // Đọc Attribute của từng phương thức
            Console.WriteLine("\nAttributes of the methods:");
            foreach (var method in user.GetType().GetMethods())
            {
                foreach (Attribute attr in method.GetCustomAttributes(false))
                {
                    MotaAttribute mota = attr as MotaAttribute;
                    if (mota != null)
                    {
                        Console.WriteLine($"{method.Name}: {mota.Description}");
                    }
                }
            }
        }
    }
}