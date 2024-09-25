using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humg_25_9_lab_27
{
    static void Main(string[] args) {

        int[] numbers = new int[] {1,2,3};
        try { 
            int i = numbers[10];
        }
        catch (Exception loi) {  
            Console.WriteLine("Loi: " + loi.Message);
            throw;
        }
        finally {
            // Luôn được thực thi dù có phát sinh ngoại lệ hay không
            Console.WriteLine("luôn thực thi");
        }
    }
}