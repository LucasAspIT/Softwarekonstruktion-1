using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4._5__Askii_art_in_console_ {
    class Program {
        static void Main(string[] args) {
            // Opgave 4.5

            // Writes askii art into the console
            Console.WriteLine("\n" +
                "               AAA                    BBBBBBBBBBBBBBBBB                CCCCCCCCCCCCC\n" +
                "              A:::A                   B::::::::::::::::B            CCC::::::::::::C\n" +
                "             A:::::A                  B::::::BBBBBB:::::B         CC:::::::::::::::C\n" +
                "            A:::::::A                 BB:::::B     B:::::B       C:::::CCCCCCCC::::C\n" +
                "           A:::::::::A                  B::::B     B:::::B      C:::::C       CCCCCC\n" +
                "          A:::::A:::::A                 B::::B     B:::::B     C:::::C\n" +
                "         A:::::A A:::::A                B::::BBBBBB:::::B      C:::::C\n" +
                "        A:::::A   A:::::A               B:::::::::::::BB       C:::::C\n" +
                "       A:::::A     A:::::A              B::::BBBBBB:::::B      C:::::C\n" +
                "      A:::::AAAAAAAAA:::::A             B::::B     B:::::B     C:::::C\n" +
                "     A:::::::::::::::::::::A            B::::B     B:::::B     C:::::C\n" +
                "    A:::::AAAAAAAAAAAAA:::::A           B::::B     B:::::B      C:::::C       CCCCCC\n" +
                "   A:::::A             A:::::A        BB:::::BBBBBB::::::B       C:::::CCCCCCCC::::C\n" +
                "  A:::::A               A:::::A       B:::::::::::::::::B         CC:::::::::::::::C\n" +
                " A:::::A                 A:::::A      B::::::::::::::::B            CCC::::::::::::C\n" +
                "AAAAAAA                   AAAAAAA     BBBBBBBBBBBBBBBBB                CCCCCCCCCCCCC");

            // Waits for user input so the console doesn't close immediately
            Console.ReadLine();
        }
    }
}