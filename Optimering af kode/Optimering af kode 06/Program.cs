using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimering_af_kode_06 {
    class Program {
        static void Main(string[] args) {

            while (true) {

                // User input that specifies how many numbers in the sequence that are shown
                int input = int.Parse(Console.ReadLine());

                Console.Clear();

                // Write out the numbers
                for (int i = 0; i < input; i++) {

                    Console.WriteLine(Fibonacci(i));

                }

                // Wait for input
                Console.WriteLine("\nPress any key to reset.");
                Console.ReadKey();
                Console.Clear();
            }

        }
        public static int Fibonacci(int n) {

            // Initial declaration of the first two Fibonacci sequence numbers
            int a = 0;
            int b = 1;


            for (int i = 0; i < n; i++) {

                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
