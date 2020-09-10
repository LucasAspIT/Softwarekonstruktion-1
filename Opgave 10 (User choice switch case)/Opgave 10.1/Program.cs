using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10._1 {
    class Program {
        static void Main(string[] args) {

            // Initial varaible declaration to be used for the user input
            byte userChoice;

            // Initial message to the user informing them about the program and giving options of what animal from the list they wish to hear about
            Console.WriteLine("You can get information about various animals by selecting one from the list below.\n");

            // List of animals the user can choose from
            Console.WriteLine("1. Parakeet");
            Console.WriteLine("2. Parrot");
            Console.WriteLine("3. Dog");
            Console.WriteLine("4. Cat");
            Console.WriteLine("5. Pig\n");

            // Inform the user to type in a number to select the animal
            Console.WriteLine("Please type in the number of the animal you wish to hear about.");

            // Save the user choice as a byte & clear console
            userChoice = byte.Parse(Console.ReadLine());
            Console.Clear();

            // Inform the user the following text is the information they requested
            Console.WriteLine("Here is the requested information: \n");

            // Show the information of the animal the user chose
            switch (userChoice) {
                case 1:
                    Console.WriteLine("\nA parakeet is any one of many small to medium-sized species of parrot, in multiple genera, that generally have long tail feathers.");
                    break;
                case 2:
                    Console.WriteLine("\nParrots, also known as psittacines, are birds of the roughly 393 species in 92 genera comprising the order Psittaciformes, found mostly in tropical and subtropical regions.");
                    break;
                case 3:
                    Console.WriteLine("\nThe dog is a domesticated carnivore of the family Canidae. It is part of the wolf-like canids, and is the most widely abundant terrestrial carnivore.");
                    break;
                case 4:
                    Console.WriteLine("\nThe cat is a domestic species of small carnivorous mammal. It is the only domesticated species in the family Felidae and is often referred to as the domestic cat to distinguish it from the wild members of the family.");
                    break;
                case 5:
                    Console.WriteLine("\nA pig is any of the animals in the genus Sus, within the even-toed ungulate family Suidae.");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error. Please select a number between 1-5 to select an animal you wish to hear more about.");
                    break;
            }

            // Wait for user input so the program doesn't close immediately
            Console.ReadKey();
        }
    }
}