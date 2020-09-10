using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7._5 {
    class Program {
        static void Main(string[] args) {
            // Initial declaration of varaibles that store user input
            int input01, input02;

            // Informs the user what the program is for & asks for the first input which it saves as an int & clears console
            Console.WriteLine("Insert numbers which will then be returned to you in order of greatest to least.\n");
            Console.Write("Insert the first number: ");
            input01 = int.Parse(Console.ReadLine());
            Console.Clear();

            // Asks for the second input which it stores as an int & clears console
            Console.Write("Insert the second number: ");
            input02 = int.Parse(Console.ReadLine());
            Console.Clear();

            // Informs the user again about what it's doing
            Console.WriteLine("The numbers from greatest to least: \n");

            // If the first input is greater then it's written first
            if (input01 > input02) {
                Console.WriteLine(input01);
                Console.WriteLine(input02);
            }
            // If the second number is greater then it's written second
            else {
                Console.WriteLine(input02);
                Console.WriteLine(input01);
            }

            // Waits for user input so the console doesn't close immediately
            Console.ReadKey();
        }
    }
}
