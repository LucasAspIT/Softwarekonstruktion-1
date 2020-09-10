using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7._3 {
    class Program {
        static void Main(string[] args) {
            // Initial variable declaration for user inputs
            int input01, input02;

            // Informs the user what the console program is for & asks for the first input & clears the console
            Console.WriteLine("This program checks if the second input is 0, and if it is, it will result in an error.\n");
            Console.Write("Insert the first number: ");
            input01 = int.Parse(Console.ReadLine());
            Console.Clear();

            // Asks for the second number & clears the console
            Console.Write("Insert the second number: ");
            input02 = int.Parse(Console.ReadLine());
            Console.Clear();

            // If the second input is 0 it errors
            if (input02 == 0) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error. The second number that was input is 0.");
            }
            // If the second input is not 0 then it's successful
            else {
                Console.WriteLine("Successful run, no errors to report.");
            }

            // Wait for user input, so console doesn't close immediately
            Console.ReadKey();
        }
    }
}