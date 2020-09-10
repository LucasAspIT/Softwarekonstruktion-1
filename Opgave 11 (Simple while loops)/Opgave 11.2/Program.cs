using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_11._2 {
    class Program {
        static void Main(string[] args) {

            // Initial declaration of varaibles to be used in 'while loops'
            int numberTable07 = 7;
            int numberTable13 = 13;
            int userTableInput, userTableResult;

            // While int is less than or equal to 70
            while (numberTable07 <= 70) {
                // Write out current int value
                Console.WriteLine(numberTable07);
                // Add 7 to int
                numberTable07 = numberTable07 + 7;
            }

            // Line to separate 'while loop' results
            Console.WriteLine("------------------------------------------------------");

            // While int is less than or equal to 130
            while (numberTable13 <= 130) {
                // Write out current int value
                Console.WriteLine(numberTable13);
                // Add 13 to int
                numberTable13 = numberTable13 + 13;
            }

            // Line to separate 'while loop' results
            Console.WriteLine("------------------------------------------------------");


            // Ask the user for input to create a 10 times table
            Console.Write("\nWrite in a number for a 10 times table: ");
            // Save their input as an int
            userTableInput = int.Parse(Console.ReadLine());
            // Set the initial value of the result to the input
            userTableResult = userTableInput;

            // While the table result is less than or equal to the initial int input times 10
            while (userTableResult <= userTableInput * 10) {
                // Write out current int value
                Console.WriteLine(userTableResult);
                // Adds the input int to the int result
                userTableResult = userTableResult + userTableInput;
            }


            // Waits for user input so the program doesn't close immediately
            Console.ReadKey();
        }
    }
}