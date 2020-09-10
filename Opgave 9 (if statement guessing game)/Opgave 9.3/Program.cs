using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9._3 {
    class Program {
        static void Main(string[] args) {

            // Initial declaration of variables used to check the value of 'x'
            int x = 0;
            int a = 1;
            int b = 2;
            int c = 3;

            // Assignment code that sets the value of 'x' - I'm guessing the value of 'x' will be 0
            // (because the 'if statement' is not true so the nested 'if statement' doesn't get run either even if it would've been true,
            // and the 'else if statement' is not true either so 'x' doesn't get changed from 0)
            if (a == 2) {
                x = 1;
                if (b == 2) {
                    x = 2;
                }
            }
            else if (c == 1) {
                x = 3;
            }


            // Prints out the result of the above if statement
            Console.WriteLine($"The value of 'x' is: {x}");

            // Waits for user input so the console doesn't immediately close
            Console.ReadKey();
        }
    }
}