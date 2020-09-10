using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_12._3 {
    class Program {
        static void Main(string[] args) {

            // The table of 10 going from 1 through 10


            // Table 1 - turn results into a string so PadLeft can be used to move numbers into a neat table
            for (int i = 1; i <= 10; i++) {
                Console.Write(i.ToString().PadLeft(4));
            }

            // Empty string to separate 'for loops' results
            Console.WriteLine();

            // Table 2
            for (int i = 2; i <= 20; i += 2) {
                Console.Write(i.ToString().PadLeft(4));
            }

            // Empty string to separate 'for loops' results
            Console.WriteLine();

            //Table 3
            for (int i = 3; i <= 30; i += 3) {
                Console.Write(i.ToString().PadLeft(4));
            }

            // Empty string to separate 'for loops' results
            Console.WriteLine();


            // Table 4
            for (int i = 4; i <= 40; i += 4) {
                Console.Write(i.ToString().PadLeft(4));
            }

            // Empty string to separate 'for loops' results
            Console.WriteLine();

            // Table 5
            for (int i = 5; i <= 50; i += 5) {
                Console.Write(i.ToString().PadLeft(4));
            }

            // Empty string to separate 'for loops' results
            Console.WriteLine();

            // Table 6
            for (int i = 6; i <= 60; i += 6) {
                Console.Write(i.ToString().PadLeft(4));
            }

            // Empty string to separate 'for loops' results
            Console.WriteLine();

            // Table 7
            for (int i = 7; i <= 70; i += 7) {
                Console.Write(i.ToString().PadLeft(4));
            }

            // Empty string to separate 'for loops' results
            Console.WriteLine();

            // Table 8
            for (int i = 8; i <= 80; i += 8) {
                Console.Write(i.ToString().PadLeft(4));
            }

            // Empty string to separate 'for loops' results
            Console.WriteLine();

            // Table 9
            for (int i = 9; i <= 90; i += 9) {
                Console.Write(i.ToString().PadLeft(4));
            }

            // Empty string to separate 'for loops' results
            Console.WriteLine();

            // Table 10
            for (int i = 10; i <= 100; i += 10) {
                Console.Write(i.ToString().PadLeft(4));
            }


            // Wait for user input so program doesn't close immediately
            Console.ReadKey();
        }
    }
}