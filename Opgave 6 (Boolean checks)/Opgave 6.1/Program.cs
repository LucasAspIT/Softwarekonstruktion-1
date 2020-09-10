using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6._1 {
    class Program {
        static void Main(string[] args) {
            // Initial declaration of variables
            byte a = 2;
            byte b = 4;


            // Various boolean checks
            // a is exactly equal to b
            Console.WriteLine(a == b);

            // a is more than b
            Console.WriteLine(a > b);

            // a is less than or the same as b
            Console.WriteLine(a <= b);

            // a minus b is more than 0
            Console.WriteLine(a - b > 0);

            // a plus b is more than 0
            Console.WriteLine(a + b > 0);

            // a is more than 1 minus b
            Console.WriteLine(a > 1 - b);


            // Wait for a user input so the console doesn't close immediately
            Console.ReadKey();
        }
    }
}