using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rode_Kode {
    class Program {

        // Method running during a fight with a monster
        public static void Fight(Hero hero, int level) {

            // Initiate random & create new monster
            Random randomMosterLevel = new Random();
            Monster monster = new Monster(level + randomMosterLevel.Next(1, 11));
            
            // Declare variable used to tell what the user is doing in the game
            string userAction = "";

            // 
            ConsoleKeyInfo userKeyInput = new ConsoleKeyInfo();
            
            // While the user hasn't pressed 'x' to exit & the monster is alive
            while (userKeyInput.KeyChar != 'x' && monster.health > 0) {

                // Clear everything
                Console.Clear();

                // Show hero health
                Console.WriteLine("\n Hero:");
                Console.WriteLine(" Health: " + hero.health);

                // Show monster health
                Console.WriteLine("\n Monster:");
                Console.WriteLine(" Health: " + monster.health + "%");

                // Show last completed user action and result
                Console.WriteLine("\n " + userAction + "\n");

                // Present options to user
                Console.WriteLine("(F) = Hit Monster");
                Console.WriteLine("(T) = Cast Spell On Monster");
                Console.WriteLine("(G) = Steal From Monster");
                Console.WriteLine("(H) = Drink Health Potion " + hero.healthPotions);

                // If the hero dies, break the loop
                if (hero.health <= 0) {
                    Console.Clear();
                    break;
                }

                // Save the user input
                userKeyInput = Console.ReadKey();

                // Take the user input key 
                switch (userKeyInput.KeyChar) {

                    // If the user pressed 'f' then hit the monster with melee & take damage
                    case 'f':
                        monster.health -= (hero.strength - monster.armor);
                        hero.health -= (monster.strength - hero.armor);
                        userAction = "You hit the monster, but it hit you back!";
                        break;

                    // If the user pressed 't' then cast a damaging spell & take damage
                    case 't':
                        monster.health -= (hero.magic - monster.magicResist);
                        hero.health -= (monster.strength - hero.armor);
                        userAction = "You cast a spell on the monster, and it hit you back";
                        break;

                    // If the user pressed 'g' then steal from the monster & take damage
                    case 'g':
                        // Successfully get gold & take damage
                        if (monster.gold >= 10) {

                            monster.gold -= 10;
                            hero.gold += 10;
                            hero.health -= (monster.strength - hero.armor);

                            userAction = "You tried to steal from the monster, and found some gold, but it hit you.";

                            // Fail to get gold & take damage
                            if (monster.gold <= 10) {

                                userAction = "You tried to steal from the monster, but couldn't find any gold on it, and it hit you.";
                                hero.health -= (monster.strength - hero.armor);
                            }
                        }
                        break;

                    // If the user pressed 'h' then use a health potion
                    case 'h':
                        if (hero.healthPotions >= 1) {

                            userAction = "You used a Health Potion. You feel refreshed.";
                            hero.health += 100;
                            hero.healthPotions -= 1;
                        }
                        break;
                }

                // Clear the console after every user action
                Console.Clear();
            }

        }

        public static void PrintMap(int[,] maze, int hX, int hY, Hero hero) {
            char chars = ' ';

            for (int y = 0; y < maze.GetLength(0); y++) {

                Console.Write("\n ");

                for (int x = 0; x < maze.GetLength(1); x++) {

                    if (x == hX && y == hY) {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("¤");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else {

                        switch (maze[y, x]) {

                            // Open space
                            case 0:
                                chars = ' ';
                                break;
                            // Wall
                            case 1:
                                chars = '#';
                                break;
                            // Health Potion
                            case 2:
                                chars = '@';
                                break;
                            // Key
                            case 3:
                                chars = '%';
                                break;
                            // Locked door
                            case 4:
                                chars = '*';
                                break;
                            // Dungeon exit
                            case 5:
                                chars = '!';
                                break;
                            // Monster
                            case 6:
                                chars = '$';
                                break;

                        }

                        Console.Write(chars);
                    }
                }
            }

            // Current stats
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n Hero Stats: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Level: " + hero.heroLevel);
            Console.WriteLine(" Strength: " + hero.strength);
            Console.WriteLine(" Health: " + hero.health);

            // Current items
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Items:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Gold: " + hero.gold);
            Console.WriteLine(" Health Potions: " + hero.healthPotions + "\n");

            // Upgrades
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Upgrade:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" B = Buy a hero level for 100 gold\n");

            // Controls
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" Controls:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" W = Move Up");
            Console.WriteLine(" S = Move Down");
            Console.WriteLine(" A = Move Left");
            Console.WriteLine(" D = Move Right\n");

            // Icon legend
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" Legend:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ¤ = Hero");
            Console.WriteLine(" $ = Enemy");
            Console.WriteLine(" @ = Health Potion");
            Console.WriteLine(" % = Door key");
            Console.WriteLine(" * = Locked door");
            Console.WriteLine(" # = Wall");

            // Exit
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Press 'X' to exit the game.");
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void Main(string[] args) {

            Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.White;

            Hero hero = new Hero();

            int heroX = 1; int heroY = 1;

            int[,] maze = {

                { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1, },

                { 1,0,1,6,0,0,0,0,0,0,0,6,0,0,0,0,0,0,6,1, },

                { 1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1, },

                { 1,0,1,0,1,1,0,0,0,0,0,0,0,1,0,0,0,1,0,1, },

                { 1,6,0,0,2,1,0,1,1,1,1,1,0,1,0,1,0,1,0,1, },

                { 1,1,1,1,1,1,0,1,0,6,0,1,0,0,0,1,2,0,0,1, },

                { 1,0,0,0,0,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1, },

                { 1,0,1,1,0,0,0,1,0,1,0,1,1,1,1,1,0,0,0,1, },

                { 1,6,1,1,2,1,6,0,0,1,0,0,0,6,0,0,0,1,6,1, },

                { 1,3,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,4,1, },

                { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,5,1, }
            };

            while (true) {

                // Clear console
                Console.Clear();

                // Hero encounters a monster
                if (maze[heroY, heroX] == 6) {

                    Fight(hero, maze[heroY, heroX]);
                    maze[heroY, heroX] = 0;
                }

                // Hero picks up a Health Potion
                if (maze[heroY, heroX] == 2) {

                    hero.healthPotions += 1; maze[heroY, heroX] = 0;
                }

                // Hero picks up a key
                if (maze[heroY, heroX] == 3) {

                    hero.itemKey += 1; maze[heroY, heroX] = 0;
                }

                if (maze[heroY, heroX] == 4 && hero.itemKey <= 1) {

                    Console.Clear();
                    Console.WriteLine("You won the game!");
                    Console.WriteLine("Your score has been saved to your bin folder");
                    Console.WriteLine("Press Enter to exit");
                    
                    HighScore(hero);

                    Console.ReadLine();
                    break;
                }

                if (hero.health <= 0) {

                    Console.Clear();

                    Console.WriteLine("\n The monster killed you!");

                    Console.WriteLine("You lost the game!");

                    Console.WriteLine("\n Press ENTER to exit.");

                    Console.ReadLine();
                    break;

                }

                PrintMap(maze, heroX, heroY, hero);
                
                ConsoleKeyInfo userKeyInput = Console.ReadKey();

                if (userKeyInput.KeyChar == 'w' && maze[heroY - 1, heroX] != 1 && maze[heroY + 1, heroX] != 5) {
                    heroY--;
                }

                if (userKeyInput.KeyChar == 'a' && maze[heroY, heroX - 1] != 1 && maze[heroY + 1, heroX] != 5) {
                    heroX--;
                }

                if (userKeyInput.KeyChar == 's' && maze[heroY + 1, heroX] != 1 && maze[heroY + 1, heroX] != 5) {
                    heroY++;
                }

                if (userKeyInput.KeyChar == 'd' && maze[heroY, heroX + 1] != 1 && maze[heroY + 1, heroX] != 5) {
                    heroX++;
                }

                if (userKeyInput.KeyChar == 'b' && hero.gold >= 100) {
                    hero.gold -= 100;
                    hero.heroLevel++;
                    hero.UPDATEHERO();
                }

                if (userKeyInput.KeyChar == 'x') {
                    break;
                }
            }
        }

        public static void HighScore(Hero hero) {

            int newHighScore = hero.gold + hero.health + (hero.healthPotions * 100) +

            (hero.heroLevel * 100);

            StreamWriter File = new StreamWriter("HighScore.txt");

            File.Write("" + newHighScore);

            File.Close();

        }
    }
}