using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_12._2 {
    class Program {
        static void Main(string[] args) {

            // int starts as 7 & as long as int is less than or equal to 70 continue running & increase the int by 7
            for (int i = 7; i <= 70; i += 7) {
                Console.WriteLine(i);
            }

            // Line to separate 'for loop' results
            Console.WriteLine("-----------------------------");

            for (int i = 13; i <= 130; i += 13) {
                Console.WriteLine(i);
            }

            // Line to separate 'for loop' results
            Console.WriteLine("-----------------------------");

            // Ask the user for input & save it as an int
            Console.Write("\nWrite in a number for a 10 times table: ");
            int userTableInput = int.Parse(Console.ReadLine());

            // Set the 'for loop' int as the same as the user input & as long as the 'for loop' int is less than or equal to the user input * 10 the continue running & add the user input to the
            // 'for loop' int
            for (int i = userTableInput; i <= userTableInput * 10; i += userTableInput) {
                Console.WriteLine(i);
            }


            // Wait for a user input so the program doesn't close immediately
            Console.ReadKey();
        }
    }
}