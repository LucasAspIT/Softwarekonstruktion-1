using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_16._3 {
    class Program {
        static void Main(string[] args) {
            // Ask the user for input
            Console.Write("Type in a number you wish to double the value of: ");
            // Store the input as an int
            int userNumber = int.Parse(Console.ReadLine());

            // Call the method DoubleUp with the parameter being the int the user input
            DoubleUp(userNumber);

            // Wait for key press so the user can see the result
            Console.ReadKey();
        }

        // Creates a method called DoubleUp expecting an int in the parameter
        private static int DoubleUp(int number) {
            // Double the int number inserted into the DoubleUp parameter
            number *= 2;
            // Write out the result
            Console.WriteLine(number);
            // Return the expected number, because the method is not a void
            return number;
        }
    }
}
