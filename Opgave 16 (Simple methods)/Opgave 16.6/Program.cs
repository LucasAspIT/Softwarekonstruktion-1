using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_16._6 {
    class Program {
        static void Main(string[] args) {

            // Create an array for strings & initialize 10 strings
            string[] arrayOfStrings = { "Hello", "Goodbye", "Up", "Down", "Left", "Right", "Sideways", "Jumping", "Crouching", "Sliding" };

            // Run the method 'PrintArray' with the parameters being the above array of strings
            PrintArray(arrayOfStrings);

            // Wait for input
            Console.ReadKey();
        }

        // Creates the method 'PrintArray' expecting a parameter of a string array
        private static void PrintArray(string[] strings) {

            // Create an int that will work as the array index & as long as the index is less than the index length (in this case 10 (0 - 9)) & add 1 to the index
            for (int i = 0; i < strings.Length; i++) {

                // Write out the specified array (names) and array index [i] - (which increases by 1 per loop, so it cycles through the entire array and prints them all out)
                Console.WriteLine(strings[i]);
            }

        }
    }
}