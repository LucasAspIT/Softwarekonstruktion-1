using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_16._1___16._2 {
    class Program {
        static void Main(string[] args) {
            // Runs the method SayHello with the parameter input being the user's name
            SayHello("Lucas");
            Console.ReadKey();
            SayGoodbye("Lucas");
            Console.ReadKey();
        }

        // Creates the method SayHello with the parameter expecting a string of the user's name & writes hello to them
        private static void SayHello(string userName) {
            Console.WriteLine($"Hello {userName}");
        }

        // Creates the method SayGoodbye with the parameter expecting a string of the user's name & writes goodbye to them
        private static void SayGoodbye(string userName) {
            Console.WriteLine($"Goodbye {userName}");
        }
    }
}
