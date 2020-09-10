using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_14._4 {
    class Program {
        static void Main(string[] args) {

            // Creating a new (string) list and initializing it with some values
            List<string> names = new List<string>() { "Hans", "Kristian", "Jens", "Karsten", "Ib" };

            foreach (string namesList in names) {
                Console.WriteLine(namesList);
            }

            // Line to separate loops
            Console.WriteLine("------------");

            // Insert a new name (Anders) as number 3 on the list & another new name (Lars) as number 2 on the list
            // In this example, it would first be: [0]Hans, [1]Kristian, [2]Jens, [3]Anders, [4]Karsten, [5]Ib
            names.Insert(3, "Anders");
            // Then it would be: [0]Hans, [1]Kristian, [2]Lars, [3]Jens, [4]Anders, [5]Karsten, [6]Ib
            names.Insert(2, "Lars");

            foreach (string namesList in names) {
                Console.WriteLine(namesList);
            }

            // Wait for input
            Console.ReadKey();
        }
    }
}