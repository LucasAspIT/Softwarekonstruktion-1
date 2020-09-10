using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4._2 {
    class Program {
        static void Main(string[] args) {
            // Opgave 4.2

            // Initial variable declaration to be used to store information the user inputs after being asked
            string firstName;
            string lastName;

            // Initial message to user asking for information
            Console.WriteLine("Please input your first name:\n");

            // Waits for text input from user and stores the first name - then clears the console
            firstName = Console.ReadLine();
            Console.Clear();

            // Waits for text input from user and stores the last name - then clears the console
            Console.WriteLine("Please input your last name:\n");
            lastName = Console.ReadLine();
            Console.Clear();

            // Uses the information the user just input to welcome them
            Console.WriteLine($"Welcome {firstName} {lastName}!");

            // Waits for input so the console doesn't close immediately
            Console.ReadLine();
        }
    }
}
