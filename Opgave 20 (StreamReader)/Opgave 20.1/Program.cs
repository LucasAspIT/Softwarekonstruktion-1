using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Opgave_20._1 {
    class Program {
        static void Main(string[] args) {

            // String that will be used to hold information from the text file being read
            string fileValues;
            int sum = 0, counter = 0;

            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader streamReader = new StreamReader(@"C:\Users\luca609a\Desktop\Softwarekonstruktion 1\Opgave 20 (StreamReader)\Opgave 20.1\Values.txt")) {


                // Print every line in text file until it returns null
                while ((fileValues = streamReader.ReadLine()) != null) {
                    Console.WriteLine(fileValues);

                    // Add every number to the total sum
                    sum += int.Parse(fileValues);

                    // Counter every number
                    counter++;
                }

                // Write out results
                Console.WriteLine($"The total of all the numbers put together is: {sum}");
                Console.WriteLine($"The total amount of numbers in the file is: {counter}");

                // Wait for input
                Console.ReadKey();
            }
        }
    }
}
