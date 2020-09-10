using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_19__Car_salesman_system_ {
    class Car {

        // Declares the variables for the car
        string Make, Model, Color;
        int Price;
        bool IsSold;

        // Creates a new method for creating cars
        public Car(string carMake, string carModel, string carColor, int carPrice, bool carIsSold) {
            Make = carMake;
            Model = carModel;
            Color = carColor;
            Price = carPrice;
            IsSold = carIsSold;
        }

        /// <summary>
        /// Puts the car on sale for 10% off
        /// </summary>
        public void PutOnSale() {
            // Calculates and removes 10% of the price
            Price = Price * 90 / 100;
        }

        /// <summary>
        /// Prints out the make, model, color and price.
        /// Will also inform if the car is sold.
        /// </summary>
        public void PrintInfo() {
            if (IsSold == false) {
                Console.WriteLine($"The car is a {Make} {Model} in the color {Color}. The price is {Price} DKK.");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            }
            else {
                Console.WriteLine($"[SOLD] The car is a {Make} {Model} in the color {Color}. The price is {Price} DKK.");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            }
        }

        // Overrides the default ToString method to instead return the make and model of the car
        public override string ToString() {
            return $"{Make} {Model}";
        }
    }
}
