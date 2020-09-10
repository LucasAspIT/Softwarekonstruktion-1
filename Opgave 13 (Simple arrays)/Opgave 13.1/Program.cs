using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_13._1 {
    class Program {
        static void Main(string[] args) {

            // Create a new array that can store 5 int values
            // int[] ages = new int[5];

            // Create new array that can store 5 int values and set the values
            int[] ages = { 25, 28, 15, 35, 14 };

            // Create an int that will work as the array index & as long as the index is less than the index length (in this case 5) & add 1 to the index
            for (int i = 0; i < ages.Length; i++) {
                // Write out the specified array (ages) and array index [i] - (which increases by 1 per loop, so it cycles through the entire array and prints them all out)
                Console.WriteLine(ages[i]);
            }

            // Wait for input
            Console.ReadKey();
        }
    }
}
