using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_14._5 {
    class Program {
        static void Main(string[] args) {

            // Create a new (int) list and initialize it with some values
            List<int> ages = new List<int>() { 13, 14, 13, 15, 13, 14, 14, 15 };

            // Write out everything on the 'ages' list
            foreach (int agesList in ages) {
                Console.WriteLine(agesList);
            }

            // Line to separate different loops
            Console.WriteLine("--------------");

            // Remove the first occurence of the given value (13 and 15 in this case)
            ages.Remove(13);
            ages.Remove(15);

            // Write out everything on the 'ages' list
            foreach (int agesList in ages) {
                Console.WriteLine(agesList);
            }

            // Line to separate different loops
            Console.WriteLine("--------------");

            // Remove the value of a specific spot in the list
            ages.RemoveAt(3);

            // Write out everything on the 'ages' list
            foreach (int agesList in ages) {
                Console.WriteLine(agesList);
            }

            // Wait for input
            Console.ReadKey();
        }
    }
}