using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7._1 {
    class Program {
        static void Main(string[] args) {
            // Initial declaration of variables
            double insertedAmount;
            double discount = 0;

            // Asks for user input
            Console.Write("Write the amount of money you wish to spend: ");
            insertedAmount = double.Parse(Console.ReadLine());

            // If the user inserts over 1000 [currency] then it will calculate a 5% discount
            if (insertedAmount > 1000) {
                discount = insertedAmount * 0.05;
                Console.WriteLine($"You got a discount of {discount}!");
            }
            // If the user does not insert over 1000 [currency] then it does not give a 5% discount
            else {
                Console.WriteLine("You did not qualify for a discount.");
            }

            // Wait for input so console doesn't close
            Console.ReadKey();
        }
    }
}