using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarHandler;

namespace Opgave_17._1 {
    class Program {
        static void Main(string[] args) {

            // Creates a new Car from the class Car and calls it 'carThingy' & Inputs expected parameter information (make, model, productionYear, color)
            Car carThingy = new Car("Ford", "Mustang", 1966, "Red");

            // Writes out some information about carThingy (hover over ToString for more information)
            Console.WriteLine(carThingy.ToString());

            // Writes out all info available from carThingy (hover over GetInfo for more information)
            Console.WriteLine(carThingy.GetInfo());

            // A line to split up the assignment
            Console.WriteLine("-------------------");

            // Changes 'carThingy's color to blue
            carThingy.Color = "Blue";

            // A test to see if the make, model or production year could be changed. They can not, as it is 'read only'
            // carThingy.Make = "Test";
            // carThingy.Model = "Test2";
            // carThingy.ProductionYear = 2000;

            // Writes out all info available from carThingy (hover over GetInfo for more information)
            Console.WriteLine(carThingy.GetInfo());

            // A line to split up the assignment
            Console.WriteLine("-------------------");

            // Returns true or false (whether the car starts or not)
            carThingy.StartCar();


            // Wait for input
            Console.ReadKey();
        }
    }
}