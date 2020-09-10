using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_13._3 {
    class Program {
        static void Main(string[] args) {

            // Create new array that can store 10 int values and set the values
            int[] numbers = new int[10] { 7, 79, 95, 73, 78, 18, 76, 80, 60, 21 };

            // Create an int that will work as the array index & as long as the index is less than the index length (in this case 10) & add 1 to the index
            for (int i = 0; i < numbers.Length; i++) {
                // Write out the specified array (numbers) and array index [i] - (which increases by 1 per loop, so it cycles through the entire array and prints them all out)
                Console.WriteLine(numbers[i]);
            }

            // Line to separate loops
            Console.WriteLine("------------------");

            // Sort array ints from lowest to highest number
            Array.Sort(numbers);

            // Repeats the same 'for loop' as above, but with the array having been sorted from lowest to highest number
            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine(numbers[i]);
            }

            // Wait for input
            Console.ReadKey();
        }
    }
}
