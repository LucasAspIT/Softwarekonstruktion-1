using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5._1 {
    class Program {
        static void Main(string[] args) {

            // Initial declaration of variables used for the simple calculator
            double number01, number02, result;

            // Information for the user about what the program does & asks for first input which it stores as a double & clears console
            Console.WriteLine("This is a very simple calculator purely for addition.\n");
            Console.Write("Input the first number: ");
            number01 = double.Parse(Console.ReadLine());
            Console.Clear();

            // Asks the user for the second input which it stores as a double & clears console
            Console.Write("Input the second number: ");
            number02 = double.Parse(Console.ReadLine());
            Console.Clear();

            // Adds the two inputs together and saves it
            result = number01 + number02;

            // Returns to the user what numbers they input and the result of adding them together
            Console.WriteLine($"You input the numbers {number01} and {number02}.\n");
            Console.WriteLine($"The two numbers added together is: {result}");

            // Waits for a user input so the console doesn't close immediately
            Console.ReadKey();
        }
    }
}