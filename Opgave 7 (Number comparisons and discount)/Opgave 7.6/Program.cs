using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7._6 {
    class Program {
        static void Main(string[] args) {
            // Initial declaration of varaibles that store user input
            int input01;

            // Informs the user what the program is for & asks for the input which it saves as an int & clears console
            Console.WriteLine("Insert a number and you will be informed whether it's positive, negative or 0.\n");
            Console.Write("Insert the number: ");
            input01 = int.Parse(Console.ReadLine());
            Console.Clear();

            // If the input is above 0 it is positive and returns that to the user & text turns green
            if (input01 > 0) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The number '{input01}' is a positive number.");
            }
            // If the number is less than 0 it is negative and returns that to the user & text turns magenta
            else if (input01 < 0) {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"The number '{input01}' is a negative number.");
            }
            // If the users enters the number '0'
            else {
                Console.WriteLine("You wrote the number '0', so it is neither positive nor negative.");
            }

            // Waits for user input so the console doesn't close immediately
            Console.ReadKey();
        }
    }
}