using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimering_af_kode_02 {
    class Program {
        static void Main(string[] args) {

            while (true) {

                // User input that specifies how many numbers in the sequence that are shown
                int input = int.Parse(Console.ReadLine());
                int number = 1;

                Console.Clear();

                // Write out the numbers
                for (int i = 0; i < input; i++) {

                    Console.WriteLine(number);
                    number *= 3;
                }

                // Wait for input
                Console.WriteLine("\nPress any key to reset.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}