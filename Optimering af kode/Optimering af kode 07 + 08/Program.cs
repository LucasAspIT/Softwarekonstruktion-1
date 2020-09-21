using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimering_af_kode_07___08 {
    class Program {
        static void Main(string[] args) {


            Random numGen = new Random();

            while (true) {
                int randomNumber = numGen.Next(1, 11);

                Console.WriteLine(LameJokes(randomNumber) + "\n");
                Console.WriteLine(FactOfLife(randomNumber));
                Console.WriteLine("\nPress any key for a new, random joke & fact of life.");

                Console.ReadKey();
                Console.Clear();
            }
        }

        /// <summary>
        /// Accepts an int between 1-10.
        /// </summary>
        /// <returns>A 'lame joke' from a switch case in string form.</returns>
        public static string LameJokes(int n) {

            string output;

            switch (n) {
                case 1:
                    output = "Where do you take someone who has been injured in a Peek-a-Boo accident?\nTo the I.C.U.";
                    break;
                case 2:
                    output = "What do you call the security outside of a Samsung Store?\nGuardians of the Galaxy.";
                    break;
                case 3:
                    output = "What do we call a crying sister?\nA crisis.";
                    break;
                case 4:
                    output = "I have a lot of good jokes about unemployed people...\nBut none of them work.";
                    break;
                case 5:
                    output = "Why was the stadium so cold?\nBecause there were a lot of fans.";
                    break;
                case 6:
                    output = "What should you do, if you get locked out of your house?\nTalk to the lock, because communication is key.";
                    break;
                case 7:
                    output = "What do you call a bee that was born is the United States?\nA USB.";
                    break;
                case 8:
                    output = "What are the strongest days of the week?\nSaturday and Sunday, the rest are week days.";
                    break;
                case 9:
                    output = "How do you help a router with digestion issues.\nGive it fiber!";
                    break;
                case 10:
                    output = "What kind of music is a balloon scared of?\nPop music.";
                    break;
                default:
                    output = "Error.";
                    break;
            }
            return output;
        }
        /// <summary>
        /// Accepts an int between 1-10.
        /// </summary>
        /// <returns>A 'fact of life' from a switch case in string form.</returns>
        public static string FactOfLife(int n) {

            string output;

            switch (n) {
                case 1:
                    output = "In 1889, the Queen of Italy, Margherita Savoy, ordered the first pizza delivery.";
                    break;
                case 2:
                    output = "You can buy eel flavoured ice cream in Japan.";
                    break;
                case 3:
                    output = "It's considered rude to write in red ink in Portugal.";
                    break;
                case 4:
                    output = "Although the Bobcat is rarely seen, it is the most common wildcat in North America.";
                    break;
                case 5:
                    output = "A cat's tail contains nearly 10 percent of all the bones in its body.";
                    break;
                case 6:
                    output = "Gecko feet have millions of tiny hairs that stick to surfaces with a special chemical bond whcih lets them climb walls and hang on by just one toe.";
                    break;
                case 7:
                    output = "The term 'astronaut' comes from greek words that mean 'star' and 'sailor.'";
                    break;
                case 8:
                    output = "The calcium in our bones and the iron in our blood come from ancient explosions of giant stars.";
                    break;
                case 9:
                    output = "The Nile Crocodile can hold its breath underwater for up to two hours while waiting fro prey.";
                    break;
                case 10:
                    output = "Jellyfish, or jellies as scientists call them, are not fish. They have no brain, no heart, and no bones.";
                    break;
                default:
                    output = "Error.";
                    break;
            }
            return output;
        }
    }
}
