namespace _11_9_19;

class Program
{
    static void Main(string[] args)
    {
        Sanpham.Product p = new Sanpham.Product();
        p.name = "Áo thun";
        p.price = 1000;
        p.description = "Áo thun abc";
        Console.WriteLine(p.GetInfo());
    }
}

