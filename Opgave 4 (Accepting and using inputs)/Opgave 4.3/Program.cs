using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4._3 {
    class Program {
        static void Main(string[] args) {
            // Opgave 4.3

            // Initial console message asking for the user to input their age while specifying the data type expected (byte)
            Console.WriteLine("How old are you? (Data type: byte)\n");
            byte age = byte.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"You are {age} years old. Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();

            // Second message asking for the user's age again, specifying a different expected data type (double)
            Console.WriteLine("How old are you? (Data type: double)\n");
            double ageDouble = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"You are {ageDouble} years old.");

            Console.ReadLine();
        }
    }
}
