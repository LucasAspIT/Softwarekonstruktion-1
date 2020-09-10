using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7._7___7._8__Letter_postage_fee_ {
    class Program {
        static void Main(string[] args) {
            // Declaration of variables used to calculate the postage fee
            double inputWeight, postageFee;
            char expressFee;

            // Tells the user what to do & saves the input as a float & clears console
            Console.WriteLine("Insert the weight of your letter to calculate the postage fee.\n");
            Console.Write("Letter weight in grams: ");
            inputWeight = double.Parse(Console.ReadLine());
            Console.Clear();

            // Asks the user if the want the express service then saves their response in a char & clears console
            Console.WriteLine("You can pay 50% extra for an express post letter.\n");
            Console.WriteLine("Do you wish to pay for the express service? Y/N");
            expressFee = char.Parse((Console.ReadLine()));
            Console.Clear();


            // If the letter weighs less than 20g
            if (inputWeight < 20) {
                postageFee = 5;
            }
            // If the letter weighs 20g or more, but less than 50g
            else if (inputWeight >= 20 && inputWeight < 50) {
                postageFee = 7;
            }
            // If the letter weighs 50g or more, but less than 100g
            else if (inputWeight >= 50 && inputWeight < 100) {
                postageFee = 10;
            }
            // If the letter weighs 100g or more, but less than 150g
            else if (inputWeight >= 100 && inputWeight < 150) {
                postageFee = 15;
            }
            // If the letter weighs 150g or more, but less than 200g
            else if (inputWeight >= 150 && inputWeight < 200) {
                postageFee = 20;
            }
            // If the letter weighs 200g or more
            else {
                postageFee = 30;
            }


            // Tells the user what they input
            Console.WriteLine($"You input the letter's weight as: {inputWeight}g\n");


            // If the user answered yes to use express then calculate the 50% extra postage fee
            if (expressFee == 'Y' || expressFee == 'y') {
                postageFee = postageFee * 0.50 + postageFee;
                Console.WriteLine("You selected the express service, 50% has been added to the fee.\n");
            }
            // If the user reponds no then do nothing
            else if (expressFee == 'N' || expressFee == 'n') {

            }
            // If the user doesn't answer yes or no then return an error in red
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error has ocurred. Please Select Y/N when selecting the express service.");
                Console.ReadKey();
                return;
            }


            // Changes the text color & returns to user the calculated postage fee
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The postage for your letter is {postageFee}kr.");


            // Waits for user input so the console doesn't immediately close
            Console.ReadKey();
        }
    }
}
