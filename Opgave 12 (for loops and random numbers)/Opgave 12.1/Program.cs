using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_12._1 {
    class Program {
        static void Main(string[] args) {

            // Declaring an int in the 'for loop' and setting it to 1 & as long as the int is less than 11 then increase it by 1 per loop
            for (int i = 1; i < 11; i++) {
                // Write the current value of the int
                Console.WriteLine(i);
            }

            // Line to separate 'for loops'
            Console.WriteLine("---------------------------------");

            // Declaring an int in the 'for loop' and setting it to 10 & as long as the int is more than 0 then decrease it by 1 per loop
            for (int i = 10; i > 0; i--) {
                // Write the current value of the int
                Console.WriteLine(i);
            }

            // Line to separate 'for loops'
            Console.WriteLine("---------------------------------");

            // Declaring an int in the 'for loop' and setting it to 1 & as long as the int is less than 21 then increase it by 1 per loop
            for (int i = 1; i < 21; i++) {

                // If the int returns 0 when the modulus operator is used by 2 (we know it's an even number) & print out the current value
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }

            // Line to separate 'for loops'
            Console.WriteLine("---------------------------------");

            // Declaring an int in the 'for loop' and setting it to 1 & as long as the int is less than 21 then increase it by 1 per loop
            for (int i = 1; i < 21; i++) {

                // If the int doesn't return 0 when the modulus operator is used by 2 (we know it's an odd number) & print out the current value
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }

            // Wait for user input so the program doesn't close immediately
            Console.ReadKey();
        }
    }
}
