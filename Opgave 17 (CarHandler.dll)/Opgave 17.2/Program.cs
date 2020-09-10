using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarHandler;

namespace Opgave_17._2 {
    class Program {
        static void Main(string[] args) {

            // Creates a new list for cars
            List<Car> cars = new List<Car>();

            // Creates two new cars
            Car car01 = new Car("Ford", "Mustang", 1966, "Red");
            Car car02 = new Car("Porsche", "911", 2004, "Silver");

            // Adds the cars to the car list
            cars.Add(car01);
            cars.Add(car02);

            // Print out information about the cars
            Console.WriteLine("Information about the cars:");
            // For each Car on the cars list
            foreach (Car item in cars) {
                // Write out the car info
                Console.WriteLine(item.GetInfo());
                Console.WriteLine(item);
            }

            // Wait for input
            Console.ReadKey();
        }
    }
}
