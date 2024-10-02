using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Humg_2_10_lab_38
{
    class Program {
        static void Main(string[] args) {
           // async await
            async Task GetData() {
                return await GetDataFromServer();
            }
        }
    }
}
