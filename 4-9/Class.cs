using System;

// Khai báo namespace
namespace CS_4_9 {

    // Khai báo tên lớp 
    class Student
    {
        // Thuộc tính
        public string name;

        private int age;

        
        

        // Phương thức khởi tạo
        public Student(string name) {
            this.name = name;
        }

        public int GetAge {
            get {
                return age;
            }
        }

        public void SetAge(int age) {
            if (age >= 0 && age <= 100) {
                this.age = age;
                Console.WriteLine($"Age set to: {age}");
            } else {
                Console.WriteLine("Invalid age");
            }
        }

        public void Study() {
            Console.WriteLine($"{name} is studying");
        }


    }
}