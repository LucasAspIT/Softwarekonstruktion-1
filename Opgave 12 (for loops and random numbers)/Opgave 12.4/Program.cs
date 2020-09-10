using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_12._4 {
    class Program {
        static void Main(string[] args) {

            // Initiate random number generator
            Random numberGenerator = new Random();

            // Declaration of variables
            // How many numbers have been generated
            int randomNumberAmount = 0;
            // Current random number
            int randomNumber = 0;

            // While the amount of randomly generated numbers is less than or equal to 0
            while (randomNumberAmount <= 10) {
                // Create an int and use the random number generator to store an int value between 1-10 (The first number is inclusive and the second number is exclusive)
                randomNumber = numberGenerator.Next(1, 11);

                // Write out the randomly generated number
                Console.WriteLine(randomNumber);

                // Add 1 to the tracker keeping track of how many numbers have been generated
                randomNumberAmount++;
            }

            // Line to separate 'while loop' results
            Console.WriteLine("---------------------------");

            // Reset the random number so it doesn't start at 6 for the next 'while loop'
            randomNumber = 0;

            while (randomNumber != 6) {
                // Create an int and use the random number generator to store an int value between 1-6 (The first number is inclusive and the second number is exclusive)
                randomNumber = numberGenerator.Next(1, 7);

                // Write out the randomly generated number
                Console.WriteLine(randomNumber);

                // Add 1 to the tracker keeping track of how many numbers have been generated
                randomNumberAmount++;
            }

            // Line to separate loop results
            Console.WriteLine("---------------------------");


            // Create int and set to 0 & as long as the int is less then 10 & add 1 to the int
            for (int i = 0; i < 10; i++) {
                // Generate a random number between 1-10 (The first number is inclusive and the second number is exclusive) and write it out
                Console.WriteLine(numberGenerator.Next(1, 11));
            }

            // Line to separate loop results
            Console.WriteLine("---------------------------");

            // Create int and set it to 0 & as long as the int is not 6 & set the int as the randomly generated number
            for (int i = 0; i != 6; i = randomNumber) {
                // Generate a random number between 1-6 (The first number is inclusive and the second number is exclusive)
                randomNumber = numberGenerator.Next(1, 7);
                Console.WriteLine(randomNumber);
            }


            // Wait for user input so the console doesn't close immediately
            Console.ReadKey();
        }
    }
}