namespace _11_9_22;

class Program
{
    class Data 
    {
        public void ShowData()
        {
            Console.WriteLine("Show Data");
        }
    }
    static void Main(string[] args)
    {
        Data d = new Data();
        d.ShowData();

        Data ddNull = new Data();
        ddNull = null;
        ddNull.ShowData();

        int? name;
        name = null;
    }
}

