using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9._4 {
    class Program {
        static void Main(string[] args) {

            // Initial declaration of variables used to check the value of 'x'
            int x = 0;
            int a = 1;
            int b = 2;
            int c = 3;

            // Assignment code that sets the value of 'x' - I'm guessing the value of 'x' will be 2 (because the 'if statement' is not true,
            // so it goes to the 'else statement' where the first nested 'if statement' is true and the second one is not)
            if (a + b == b) {
                x = 1;
            }
            else {
                if (b - a == a) {
                    x = 2;
                }
                if (c - b == b) {
                    x = 3;
                }
            }


            // Prints out the result of the above if statement
            Console.WriteLine($"The value of 'x' is: {x}");

            // Waits for user input so the console doesn't immediately close
            Console.ReadKey();
        }
    }
}