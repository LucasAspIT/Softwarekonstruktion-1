using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_16._5 {
    class Program {
        static void Main(string[] args) {
            // Asks user for input
            Console.WriteLine("Write two numbers to find out which is the greatest \n");

            // Saves the first and second input as ints
            Console.Write("First number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int b = int.Parse(Console.ReadLine());

            // Calls the method 'FindGreatestNumber' with the parameters being the two user int inputs
            FindGreatestNumber(a, b);

            // Waits for input
            Console.ReadKey();
        }

        // Creates the int method 'FindGreatestNumber' which expectes two int parameters
        private static int FindGreatestNumber(int a, int b) {
            // If 'a' is greater than 'b'
            if (a > b) {
                Console.WriteLine(a + " is the greatest number");
            }
            // If 'a' is the same as 'b'
            else if (a == b) {
                Console.WriteLine(a + " and " + b + " are the same number");
            }
            // Else 'b' is greater than 'a'
            else {
                Console.WriteLine(b + " is the greatest number");
            }
            // Return info because the method is not a void
            return a + b;
        }
    }
}
