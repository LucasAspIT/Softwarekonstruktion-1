using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_14._3 {
    class Program {
        static void Main(string[] args) {

            // Creation of an empty (int) list called 'ages'
            List<int> ages = new List<int>();

            // Adding different numbers to the list 'ages'
            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(51);

            // Creation of an empty (string) list called 'names'
            List<string> names = new List<string>();

            // Adding different strings to the list 'names'
            names.Add("Jens");
            names.Add("Karl");
            names.Add("Johannes");
            names.Add("Anton");
            names.Add("Nicklas");

            // Creating a new (double) list and initializing it with some values
            List<double> percentages = new List<double>() { 0.75, 0.23, 0.86, 0.17 };

            // Creating a new (bool) list and initializing it with some values
            List<bool> areMarried = new List<bool>() { true, false, false, true, true };


            // Write out everything in the 'ages' list
            for (int i = 0; i < ages.Count; i++) {
                Console.WriteLine(ages[i]);
            }

            // Line to separate loops
            Console.WriteLine("--------------------");

            // Write out everything in the 'names' list
            for (int i = 0; i < names.Count; i++) {
                Console.WriteLine(names[i]);
            }

            // Line to separate loops
            Console.WriteLine("--------------------");

            /*
            // Example of a foreach loop
            Console.WriteLine("Print array:");

            // Creating an array 
            int[] anExampleArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            // foreach loop begin & it will run until the last element of the array 
            foreach (int items in anExampleArray) {
                Console.WriteLine(items);
            }

            // foreach syntax:
            foreach(data_type var_name in collection_variable) {
                // Statements to be executed
            }
            */

            // Write out everything in the 'percentages' list
            foreach (double percentageList in percentages) {
                Console.WriteLine(percentageList);
            }

            // Line to separate loops
            Console.WriteLine("--------------------");

            // Write out everything in the 'areMarried' list
            foreach (bool areMarriedList in areMarried) {
                Console.WriteLine(areMarriedList);
            }

            // Wait for input
            Console.ReadKey();
        }
    }
}