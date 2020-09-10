using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Opgave_18._1___18._2___18._3___18._4 {
    class Box {
        int width, height, length;

        public Box(int boxHeight, int boxLength, int boxWidth) {
            width = boxWidth;
            length = boxLength;
            height = boxHeight;
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public int Length { get => length; set => length = value; }

        /// <summary>
        /// Prints out the height, length and width of the specified box
        /// </summary>
        public void PrintInfo() {
            Console.WriteLine("The box measurements:");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
        }



    }
}