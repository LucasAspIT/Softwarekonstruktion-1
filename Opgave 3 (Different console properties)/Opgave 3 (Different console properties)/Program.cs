using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_3 {
    class Program {
        static void Main(string[] args) {
            // Changes the background color of text and the text color, as well as the window size of the console
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowHeight = 50;
            Console.WindowWidth = 150;

            // Random text to see effects of above console settings
            Console.WriteLine("Sample text");

            // Beeps playing the start of the Tetris theme song
            // Console.Beep(1320, 500); Console.Beep(990, 250); Console.Beep(1056, 250); Console.Beep(1188, 250); Console.Beep(1320, 125); Console.Beep(1188, 125); Console.Beep(1056, 250); Console.Beep(990, 250); Console.Beep(880, 500); Console.Beep(880, 250); Console.Beep(1056, 250); Console.Beep(1320, 500); Console.Beep(1188, 250); Console.Beep(1056, 250); Console.Beep(990, 750); Console.Beep(1056, 250); Console.Beep(1188, 500); Console.Beep(1320, 500); Console.Beep(1056, 500); Console.Beep(880, 500); Console.Beep(880, 500);

            // Waits for a user input so the console doesn't immediately close
            Console.ReadLine();
        }
    }
}
