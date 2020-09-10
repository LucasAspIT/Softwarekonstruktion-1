using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_19__Car_salesman_system_ {
    class Program {
        static void Main(string[] args) {

            // Creates new cars and sets their parameters
            Car car1 = new Car("Dacia", "Logan", "Beige", 170000, false);
            Car car2 = new Car("Toyota", "Yaris", "Red", 89000, true);
            Car car3 = new Car("Honda", "Civic", "White", 199000, false);

            // Create the car list to be used for storing cars the user inputs
            List<Car> carList = new List<Car>();

            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);

            Console.WriteLine(carList[1]);
            Console.ReadKey();

            // While true (in other words, run while loop forever)
            while (true) {
                // Greet the user & ask them to choose an option
                Console.WriteLine("Hello and welcome to the car administration");
                Console.WriteLine("Choose an option:\n");

                // Present the options
                Console.WriteLine("(1) Add new car");
                Console.WriteLine("(2) See information on all cars");
                Console.WriteLine("(3) Put a car on sale");

                // Ask the user to choose an option & store the answer as a byte
                Console.Write("Choose option one (1), two (2) or three (3): ");
                byte optionChoice = byte.Parse(Console.ReadLine());

                // If the user chooses option 1
                if (optionChoice == 1) {
                    // Inform the user what they chose and ask them for the various info needed & save the info they input
                    Console.WriteLine("You chose to add a new car to the system\n");
                    Console.Write("Please type in the make of the car: ");
                    string userInputCarMake = Console.ReadLine();
                    Console.Write("Please type in the model of the car: ");
                    string userInputCarModel = Console.ReadLine();
                    Console.Write("Please type in the color of the car: ");
                    string userInputCarColor = Console.ReadLine();
                    Console.Write("Please type in the price of the car: ");
                    int userInputCarPrice = int.Parse(Console.ReadLine());
                    Console.Write("Please type in if the car has been sold (true) or not (false): ");
                    bool userInputCarIsSold = bool.Parse(Console.ReadLine());

                    // Use the saved info gathered just above to create a new Car object & input the info the user wrote
                    Car newCar = new Car(userInputCarMake, userInputCarModel, userInputCarColor, userInputCarPrice, userInputCarIsSold);
                    // Add the newly created Car object to the carList
                    carList.Add(newCar);

                    // Inform the user what they just input
                    Console.WriteLine($"\nYou input the following car into the system: \n");
                    newCar.PrintInfo();
                    Console.WriteLine("Press any key to continue.");
                    // Once they press a key, clear the console and return to the start of the 'while loop'
                    Console.ReadKey();
                    Console.Clear();
                }
                // If the user chooses option 2
                else if (optionChoice == 2) {
                    Console.WriteLine("\nHere's a list of all the cars in the administration system: \n");
                    // For every Car object in the carList
                    foreach (Car item in carList) {
                        // Write out all info on all cars in the carList
                        item.PrintInfo();
                    }
                    // Wait for user input so they can see the results
                    Console.ReadKey();
                    Console.Clear();
                }
                // If the user chooses option 3
                else {
                    foreach (Car item in carList) {

                    }
                }






                // 10% off sale
                // car3.PutOnSale();

                // Prints out the info of the cars
                // car1.PrintInfo();
                // car2.PrintInfo();
                // car3.PrintInfo();

                // Write out the overridden (in the Car class) ToString
                // Console.WriteLine(car1);

                // Wait for input
                Console.ReadKey();
            }
        }
    }
}