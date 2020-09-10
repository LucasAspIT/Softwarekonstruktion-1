using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            /*String Output = "Hello World";
            String Name = "Lucas Kyhl";
            String FavouriteColour = "Crimson red";
            String Sex = "Male";
            String Sex2 = Sex.ToLower();
            byte Age = 24;
            double Height = 1.75;
            bool Alive = true;

            Console.WriteLine($"Your name is {Name}");
            Console.WriteLine($"You're {Age} years old");
            Console.WriteLine($"{FavouriteColour} is your favourite colour");
            Console.WriteLine($"You are {Height}m tall");
            Console.WriteLine($"You were born a {Sex2}");
            Console.WriteLine($"You are currently alive: {Alive}");

            Console.ReadLine();*/

            // Initial variable declaration to be used to store information the user inputs after being asked
            String name;
            String favouriteColour;
            String sex;
            String sex2;
            byte age;
            double height;
            bool alive;

            // Sets the console text to green
            Console.ForegroundColor = ConsoleColor.Green;

            // Initial greeting to the user after the console opens
            Console.WriteLine("Hello. Please input your information.\n");

            // The console asks the user for information which it then stores to be used at the end
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("How old are you?");
            age = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("What is your favourite colour?");
            favouriteColour = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is your height in meters?");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("What sex were your born as?");
            sex = Console.ReadLine();
            sex2 = sex.ToLower();
            Console.Clear();

            Console.WriteLine("Is it true or false that you are alive currently?");
            alive = Convert.ToBoolean(Console.ReadLine());
            Console.Clear();


            // Console prints back the information the user gave earlier 
            Console.WriteLine($"Your name is {name}.\n");
            Console.WriteLine($"You're {age} years old.\n");
            Console.WriteLine($"{favouriteColour} is your favourite colour.\n");
            Console.WriteLine($"You are {height}m tall.\n");
            Console.WriteLine($"You were born a {sex2}.\n");
            Console.WriteLine($"You are currently alive: {alive}.");


            Console.ReadLine();
        }
    }
}
