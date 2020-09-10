using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4._1 {
    class Program {
        static void Main(string[] args) {
            // Opgave 4.1

            // Initial variable declaration to be used to store information the user inputs after being asked
            string userInput;

            // Initial message to user
            Console.WriteLine("Write some text.");

            // Waits for text input from user and stores said input
            userInput = Console.ReadLine();

            // Repeats what the user just input
            Console.WriteLine(userInput);

            // Waits for input so the console doesn't close immediately
            Console.ReadLine();
        }
    }
}
