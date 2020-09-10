using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_11._1 {
    class Program {
        static void Main(string[] args) {

            // Initial declaration of variables to be used in 'while loops'
            int countUp = 0;
            int countDown = 10;
            int countEven = 0;
            int countOdd = 0;

            // While the int is less than 10 keep increasing it by 1 & write out its current value
            while (countUp < 10) {
                countUp++;
                Console.WriteLine(countUp);
            }

            // Line to separate 'while loop' results
            Console.WriteLine("------------------------------------------------------");

            // While the int is greater than 0 keep decreasing it by 1 & write out its current value
            while (countDown > 0) {
                Console.WriteLine(countDown);
                countDown--;
            }

            // Line to separate 'while loop' results
            Console.WriteLine("------------------------------------------------------");

            // While the int is less than 20, keep increasing it by 1
            while (countEven < 20) {
                countEven++;

                // If it returns 0 when the modulus operator is used by 2 (we know it's an even number) & print out the current value
                if (countEven % 2 == 0) {
                    Console.WriteLine(countEven);
                }
            }

            // Line to separate 'while loop' results
            Console.WriteLine("------------------------------------------------------");

            // While the int is less than 20, keep increasing it by 1
            while (countOdd < 20) {
                countOdd++;

                // If it doesn't return 0 when the modulus operator is used by 2 (we know it's an odd number) & print out the current value
                if (countOdd % 2 != 0) {
                    Console.WriteLine(countOdd);
                }
            }


            // Waits for user input so the program doesn't close immediately
            Console.ReadKey();
        }
    }
}
