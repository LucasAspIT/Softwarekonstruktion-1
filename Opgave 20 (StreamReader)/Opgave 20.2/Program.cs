using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Opgave_20._2 {
    class Program {
        static void Main(string[] args) {

            // String that will be used to hold information from the text file being read
            string fileValues;

            // Box sides
            int boxHeight, boxLength, boxWidth;

            // Create a list for boxes
            List<Box> boxList = new List<Box>();

            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader streamReader = new StreamReader(@"C:\Users\luca609a\Desktop\Softwarekonstruktion 1\Opgave 20 (StreamReader)\Opgave 20.2\Boxes.txt")) {


                // Read and set fileValues as the currently read line until there are no more lines
                while ((fileValues = streamReader.ReadLine()) != null) {

                    // Split the line at every comma to get 3 numbers
                    string[] boxArray = fileValues.Split(',');

                    // Save the 3 numbers on the current line
                    boxHeight = int.Parse(boxArray[0]);
                    boxLength = int.Parse(boxArray[1]);
                    boxWidth = int.Parse(boxArray[2]);

                    // Create a box using the 3 numbers
                    Box newBox = new Box(boxHeight, boxLength, boxWidth);

                    // Add the new box to a list
                    boxList.Add(newBox);

                    // Print out information about the box
                    newBox.PrintInfo();
                }
            }

            // Wait for input
            Console.ReadKey();
        }
    }
}
