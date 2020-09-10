using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_11._3 {
    class Program {
        static void Main(string[] args) {

            // Initial declaration of variables to be used in while loop
            int userInput = 0;

            // Inform user what to do
            Console.WriteLine("Write any number. If you write a number between 1-10 the program will end.");

            // While the user input is less than 1 or more than 10
            while (userInput < 1 || userInput > 10) {
                // Save user input as int
                userInput = int.Parse(Console.ReadLine());
            }

            // Write message to user once they exit the while loop
            Console.WriteLine($"You wrote the number '{userInput}' which is a number between 1-10, the program will end.");


            // Waits for user input so the program doesn't close immediately
            Console.ReadKey();
        }
    }
}
