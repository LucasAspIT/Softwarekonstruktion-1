using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7._2 {
    class Program {
        static void Main(string[] args) {
            // Initial declaration of variables
            int number01, number02;

            // Introduces the user to what the console is used for & then asks for the first input and saves the number as an int & clears the console
            Console.WriteLine("Type two numbers to check if they are the same or not.\n");
            Console.Write("Write the first number: ");
            number01 = int.Parse(Console.ReadLine());
            Console.Clear();

            // Asks for the second number input and saves the number as an int & clears the console
            Console.Write("Write the second number: ");
            number02 = int.Parse(Console.ReadLine());
            Console.Clear();

            // Informs the user what numbers were inserted
            Console.WriteLine($"You wrote the numbers {number01} and {number02}.\n");

            // If the numbers are identical it informs the user
            if (number01 == number02) {
                Console.WriteLine("The numbers are identical.");
            }
            // If the numbers are not identical it informs the user
            else {
                Console.WriteLine("The numbers are NOT identical.");
            }

            // Wait for user input so the console doesn't close immediately
            Console.ReadKey();
        }
    }
}