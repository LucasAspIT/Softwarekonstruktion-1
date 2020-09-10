using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_14._1 {
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

            // Wait for input
            Console.ReadKey();
        }
    }
}