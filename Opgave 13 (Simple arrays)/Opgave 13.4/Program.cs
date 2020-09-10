using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_13._4 {
    class Program {
        static void Main(string[] args) {

            // Create new array that can store 10 int values and set the values
            int[] numbers = new int[10] { 5, 13, 65, 23, 43, 76, 29, 54, 99, 71 };

            // Create an int that will work as the array index & as long as the index is less than the index length (in this case 10) & add 1 to the index
            for (int i = 0; i < numbers.Length; i++) {
                // Write out the specified array (numbers) and array index [i] - (which increases by 1 per loop, so it cycles through the entire array and prints them all out) & add 5 to each number
                Console.WriteLine(numbers[i] + 5);
            }

            // Wait for input
            Console.ReadKey();
        }
    }
}
