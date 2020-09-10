using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5._2___5._3___5._4 {
    class Program {
        static void Main(string[] args) {

            // Initial declaration of variables used for the simple calculator
            double number01, number02, resultAddition, resultSubtraction, resultMultiplication, resultDivision, resultRemainder;
            bool programRunning = true;

            // Makes the console slightly wider to fit the introduction below on one line (the number is how many characters wide the console is)
            Console.WindowWidth = 148;

            // While this is true, and it always will be - loop the program
            while (programRunning == true) {
                // Information for the user about what the program does & asks for first input which it stores as a double & clears console
                Console.WriteLine("This is a very simple calculator which will use addition, subtraction, multiplication, division and the remainder function on two numbers you input.\n");
                Console.Write("Input the first number: ");
                number01 = double.Parse(Console.ReadLine());
                Console.Clear();

                // Asks the user for the second input which it stores as a double & clears console
                Console.Write("Input the second number: ");
                number02 = double.Parse(Console.ReadLine());
                Console.Clear();

                // Calculates the two numbers using addition, subtraction, multiplication and division and saves the results
                resultAddition = number01 + number02;
                resultSubtraction = number01 - number02;
                resultMultiplication = number01 * number02;
                resultDivision = number01 / number02;
                resultRemainder = number01 % number02;

                // Returns to the user what numbers they input and the result of adding them together
                Console.WriteLine($"You input the numbers {number01} and {number02}.\n");

                Console.WriteLine($"Addition: {resultAddition}");
                Console.WriteLine($"Subtraction: {resultSubtraction}");
                Console.WriteLine($"Multiplication: {resultMultiplication}");
                Console.WriteLine($"Division: {resultDivision}");
                Console.WriteLine($"Remainder: {resultRemainder}");

                // Waits for a user input so the console doesn't close immediately
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}