using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimering_af_kode_05 {
    class Program {
        static void Main(string[] args) {

            while (true) {

                // User input that specifies how many numbers in the sequence that are shown
                int input = int.Parse(Console.ReadLine());

                Console.Clear();

                // Write out the numbers
                for (int i = 2; i < input; i++) {

                    if(IsPrime(i)) {
                        Console.WriteLine(i);
                    }

                }

                // Wait for input
                Console.WriteLine("\nPress any key to reset.");
                Console.ReadKey();
                Console.Clear();
            }

        }
            /// <summary>
            /// Checks if the number is prime.
            /// </summary>
            /// <returns>'True' if the number is prime, and 'False' if it is not.</returns>
            public static bool IsPrime(int number) {
                if (number == 2) {
                return true;
                }
                if (number % 2 == 0) {
                return false;
                }

                var boundary = (int)Math.Floor(Math.Sqrt(number));

                for (int i = 3; i <= boundary; i += 2)
                    if (number % i == 0) {
                        return false;
                }

                return true;
            }
    }
}