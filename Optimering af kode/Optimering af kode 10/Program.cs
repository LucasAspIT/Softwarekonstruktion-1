using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimering_af_kode_10 {
    class Program {
        static void Main(string[] args) {

            int[] array = { 3, 7, 54, 87, 746, 2432, 6543, 654, 32, 432};

            Console.WriteLine(array.Min());
            Console.ReadKey();
        }
    public static void MinArray(Array input) {
            Console.WriteLine(input.Min());
        }

    }

}
