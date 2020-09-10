using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_and_catch_experimentation {
    class Program {
        static void Main(string[] args) {
            // Try & catch experimentation

            // Setting the userInputAge to String.Empty allows you to check if the string is empty later when there should've been an input
            string userInputAge = String.Empty;

            // Initial load that asks the user a question which expects a 'byte' data type answer
            Console.WriteLine("How old are you?\n");
            userInputAge = Console.ReadLine();

            // Tries to parse userInputAge to userAge so the string gets converted to a 'byte' data type
            try {
                byte userAge = byte.Parse(userInputAge);
                Console.WriteLine(userAge);
            }
            // If a FormatException error occurs, like when the users inputs letters when numbers are expected, then it returns an error
            catch (FormatException) {
                Console.WriteLine($"Unable to parse '{userInputAge}', please make sure you input a valid age.");
            }

            Console.ReadLine();
        }
    }
}