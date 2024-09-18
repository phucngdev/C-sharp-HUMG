namespace _18_9_26
{

    class Student
    {
        public readonly string name; // chỉ đọc với readonly

        public Student(string _name)
        {
            this.name = _name;
        }

        // tĩnh với , dùng cho mọi đối tượng thuộc lớp
        // chỉ khởi tạo 1 l
        public static int count = 0;

        public void Count()
        {
            Student.count++;
        }

        public void PrintCount()
        {
            Console.WriteLine($"so user gọi : {Student.count}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("A");
            Student s2 = new Student("B");

            s1.Count(); // count = 1
            s2.Count(); // count = 2

            s1.PrintCount();

            Console.WriteLine(s1.name); // chỉ đọc không gán được name
        }
    }
}


