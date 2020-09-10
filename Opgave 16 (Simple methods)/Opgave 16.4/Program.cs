using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_16._4 {
    class Program {
        static void Main(string[] args) {
            // Asks user for input
            Console.WriteLine("Write two numbers to add together \n");

            // Saves the first and second input as ints
            Console.Write("First number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int b = int.Parse(Console.ReadLine());

            // Calls the method 'Addition' with the parameters being the two user int inputs
            Addition(a, b);

            // Waits for input
            Console.ReadKey();
        }

        // Creates the method int 'Addition' which expectes two int parameters
        private static int Addition(int a, int b) {

            // Create an int the stores the results of the two parameter inputs added together
            int result = a + b;
            // Write the result
            Console.WriteLine(result);
            // Return info because the method is not a void
            return a + b;
        }
    }
}
