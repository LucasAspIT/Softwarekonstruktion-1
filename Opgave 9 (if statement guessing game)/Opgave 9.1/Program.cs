using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9._1 {
    class Program {
        static void Main(string[] args) {
            // Initial declaration of variables used to check the value of 'x'
            int x = 0;
            int a = 1;
            int b = 2;
            int c = 3;

            // Assignment code that sets the value of 'x' - I'm guessing the value of 'x' will be 3 (because the last if statement that runs is true and sets x to 3)
            if (a == 1) {
                x = 1;
            }
            if (b == 1) {
                x = 2;
            }
            if (c == 3) {
                x = 3;
            }


            // Prints out the result of the above if statement
            Console.WriteLine($"The value of 'x' is: {x}");

            // Waits for user input so the console doesn't immediately close
            Console.ReadKey();
        }
    }
}
