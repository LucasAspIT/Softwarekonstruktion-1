using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_13._2 {
    class Program {
        static void Main(string[] args) {

            // Create new array that can store 4 string values and set the values
            string[] names = new string[4] { "Hans", "Anton", "Betina", "Daniel" };

            // Create an int that will work as the array index & as long as the index is less than the index length (in this case 4) & add 1 to the index
            for (int i = 0; i < names.Length; i++) {
                // Write out the specified array (names) and array index [i] - (which increases by 1 per loop, so it cycles through the entire array and prints them all out)
                Console.WriteLine(names[i]);
            }

            // Line to split up loops
            Console.WriteLine("----------------------");

            // Update a string in the array (in this case index 3)
            names[3] = "Kong Daniel";

            // Repeat the above 'for loop' with the updated index 3
            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine(names[i]);
            }

            // Wait for input
            Console.ReadKey();
        }
    }
}