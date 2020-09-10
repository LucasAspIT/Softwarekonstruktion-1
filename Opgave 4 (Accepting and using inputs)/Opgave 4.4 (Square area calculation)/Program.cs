using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4._4__Square_area_calculation_ {
    class Program {
        static void Main(string[] args) {
            // Opgave 4.4

            // Initial variable declaration to accept store user input to be used to calculate the area of a square
            double squareLength, squareHeight, squareArea;

            // Informing the user what they can do and asks them for the first input which it then stores
            Console.WriteLine("Calculate the area of a square.\n");
            Console.WriteLine("What is the length of the square in centimeters?");
            // Takes the string input from the user and parses it into a data type of 'double' so it can be calculated later
            squareLength = double.Parse(Console.ReadLine());
            Console.Clear();

            // Asks the user for the second input that it stores
            Console.WriteLine("What is the height of the square in centimeters?");
            // Takes the string input from the user and parses it into a data type of 'double' so it can be calculated later
            squareHeight = double.Parse(Console.ReadLine());
            Console.Clear();

            // Calculate the area of the square from the earlier user input
            squareArea = squareLength * squareHeight;

            // Displays the result of the calculation
            Console.WriteLine($"The area of the square is: {squareArea}cm2");

            // Waits for a user input so the results of the above calculation can be viewed before the console closes
            Console.ReadLine();
        }
    }
}
