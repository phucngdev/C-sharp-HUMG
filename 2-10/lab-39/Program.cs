using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humg_2_10_lab_39
{
    class Program {
        static void Main(string[] args) {
            // Lớp Type 
            // GetMethods() trả về tên các phương public
            Type type = typeof(Math);
            var publicMethods = type.GetMethods().Where(method => method.IsPublic);
            foreach (var method in publicMethods) {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine("----------------------------------------------------------------");

            // GetFields() lấy các trường public
            Type intType = typeof(Math);
            var publicFields = intType.GetFields().Where(field => field.IsPublic);
            foreach (var field in publicFields) {
                Console.WriteLine(field.Name);
            }
            Console.WriteLine("----------------------------------------------------------------");
            // GetEvents() lấy các sự kiện
            // GetProperty(String) lấy đối tượng PropertyInfo biểu thị thuộc tính với tên chỉ ra
            


        }
    }
}
