using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7._4 {
    class Program {
        static void Main(string[] args) {
            // Initial declaration of variables that will save user inputs
            int input01, input02;

            // Informs the user what the console program does & asks for the first input which it saves to an int & clears console
            Console.WriteLine("Here you can compare two numbers to see which one is larger or if they're the same.\n");
            Console.Write("Input the first number: ");
            input01 = int.Parse(Console.ReadLine());
            Console.Clear();

            // Asks for the second input which it saves to an int & clears console
            Console.Write("Input the second number: ");
            input02 = int.Parse(Console.ReadLine());
            Console.Clear();

            // Informs the user what numbers they input
            Console.WriteLine($"You input the numbers {input01} and {input02}.\n");

            // If the numbers are identical, the console informs the user
            if (input01 == input02) {
                Console.WriteLine("The numbers are identical.");
            }
            // If the first input is larger than the second, it informs the user
            else if (input01 > input02) {
                Console.WriteLine($"The first input '{input01}' is larger than the second input '{input02}'.\n");
                Console.WriteLine($"In other words, the number '{input01}' is the largest number.");
            }
            // If neither of above is true, then the second input is the largest nubmer and it informs the user
            else {
                Console.WriteLine($"The first input '{input01}' is smaller than the second input '{input02}'\n");
                Console.WriteLine($"In other words, the number '{input02}' is the largest number.");
            }

            // Waits for user input so the console doesn't close immediately
            Console.ReadKey();
        }
    }
}