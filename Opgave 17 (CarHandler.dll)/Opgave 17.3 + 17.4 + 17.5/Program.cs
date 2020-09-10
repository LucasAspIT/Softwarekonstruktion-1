using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarHandler;

namespace Opgave_17._3___17._4___17._5 {
    class Program {
        static void Main(string[] args) {

            // Create the car list to be used for storing cars the user inputs
            List<Car> carList = new List<Car>();

            // While true (in other words, run while loop forever)
            while (true) {
                // Greet the user & ask them to choose an option
                Console.WriteLine("Hello and welcome to the car administration");
                Console.WriteLine("Choose an option:\n");

                // Present the options
                Console.WriteLine("(1) Add new car");
                Console.WriteLine("(2) See information on all cars");
                Console.WriteLine("(3) Search for cars of a specific type");

                // Ask the user to choose an option & store the answer as a byte
                Console.Write("Choose option one (1), two (2) or three (3): ");
                byte optionChoice = byte.Parse(Console.ReadLine());

                // If the user chooses option 1
                if (optionChoice == 1) {
                    Console.WriteLine("Here's a list of all the cars in the administration system: ");
                    // For every Car object in the carList
                    foreach (Car item in carList) {
                        // Write out all info on all cars in the carList
                        Console.WriteLine(item.GetInfo());
                    }
                    // Wait for user input so they can see the results
                    Console.ReadKey();
                    Console.Clear();
                }
                // If the user chooses option 2
                else if (optionChoice == 2) {
                    // Inform the user what they chose and ask them for the various info needed & save the info they input
                    Console.WriteLine("You chose to add a new car to the system\n");
                    Console.Write("Please type in the make of the car: ");
                    string userInputCarMake = Console.ReadLine();
                    Console.Write("Please type in the model of the car: ");
                    string userInputCarModel = Console.ReadLine();
                    Console.Write("Please type in the production year of the car: ");
                    int userInputCarYear = int.Parse(Console.ReadLine());
                    Console.Write("Please type in the color of the car: ");
                    string userInputCarColor = Console.ReadLine();

                    // Use the saved info gathered just above to create a new Car object & input the info the user wrote
                    Car newCar = new Car(userInputCarMake, userInputCarModel, userInputCarYear, userInputCarColor);
                    // Add the newly created Car object to the carList
                    carList.Add(newCar);

                    // Inform the user what they just input
                    Console.WriteLine($"You input {newCar.GetInfo()} into the system.\n");
                    Console.WriteLine("Press any key to continue.");
                    // Once they press a key, clear the console and return to the start of the 'while loop'
                    Console.ReadKey();
                    Console.Clear();
                }
                // If the user chooses option 3
                else {
                    foreach (Car item in carList) {

                    }
                }
            }

        }
    }
}
