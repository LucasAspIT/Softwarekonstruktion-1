using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10._2 {
    class Program {
        static void Main(string[] args) {

            // Initial varaible declaration to be used for the user input
            byte userChoice;

            // Initial message to the user informing them about the program and giving options of what animal from the list they wish to hear about
            Console.WriteLine("You can get information about the various grades you can get on assignments and exams.\n");

            // List of grades the user can choose from
            Console.WriteLine("1. 12");
            Console.WriteLine("2. 10");
            Console.WriteLine("3. 7");
            Console.WriteLine("4. 4");
            Console.WriteLine("5. 02");
            Console.WriteLine("6. 00");
            Console.WriteLine("7. -3\n");

            // Inform the user to type in a number to select the grade
            Console.WriteLine("Please type in the selection number of the grade you wish to hear about.");

            // Save the user choice as a byte & clear console
            userChoice = byte.Parse(Console.ReadLine());
            Console.Clear();

            // Inform the user the following text is the information they requested
            Console.WriteLine("Here is the requested information: \n");

            // Show the information of the animal the user chose
            switch (userChoice) {
                case 1:
                    Console.WriteLine("\nGrade 12 is given for an excellent performance.");
                    break;
                case 2:
                    Console.WriteLine("\nGrade 10 is given for a really great performance.");
                    break;
                case 3:
                    Console.WriteLine("\nGeade 7 is given for a good performance.");
                    break;
                case 4:
                    Console.WriteLine("\nGrade 4 is given for a decent performance.");
                    break;
                case 5:
                    Console.WriteLine("\nGrade 02 is given for a sufficient performance.");
                    break;
                case 6:
                    Console.WriteLine("\nGrade 00 is given for an insufficient performance.");
                    break;
                case 7:
                    Console.WriteLine("\nGrade -3 is given for a terrible performance.");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error. Please select a number between 1-7 to select a grade you wish to hear more about.");
                    break;
            }

            // Wait for user input so the program doesn't close immediately
            Console.ReadKey();
        }
    }
}