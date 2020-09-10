using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morris_the_Miner_Alt3 {
    class Program {
        static void Main(string[] args) {
            int sleepiness = 0, thirst = 0, hunger = 0, whisky = 0, gold = 0;

            int stateSwitch = 1;

            bool alive = true;

            for (int i = 0; i < 1000; i++) {

                if (alive) {

                    // If Morris dies
                    if (sleepiness > 100 || thirst > 100 || hunger > 100 || whisky > 10) {

                        alive = false;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nMorris R.I.P \n");
                        break;
                    }

                    // Optimize end gold result by mining as much as possible
                    if (i >= 999) {
                        stateSwitch = 1;
                    }
                    else {

                        // Morris goes mining
                        if (alive && sleepiness < 95 && thirst <= 95 && hunger < 95) {
                            stateSwitch = 1;
                        }
                        // Morris goes to sleep
                        else if (alive && thirst <= 99 && hunger <= 99 && sleepiness >= 95) {
                            stateSwitch = 2;
                        }
                        // Morris eats food
                        else if (alive && sleepiness < 100 && hunger > 85) {
                            stateSwitch = 3;
                        }
                        // Morris drinks whisky
                        else if (alive && sleepiness < 100 && thirst >= 95 && whisky >= 1) {
                            stateSwitch = 4;
                        }
                        else {
                            stateSwitch = 1;
                        }

                        // Morris buys whisky
                        if (alive && whisky < 1 && gold >= 1 && sleepiness < 95) {
                            stateSwitch = 5;
                        }
                    }

                    switch (stateSwitch) {
                        // If Morris is mining
                        case 1:
                            // Change the stats
                            sleepiness += 5;
                            thirst += 5;
                            hunger += 5;
                            // whisky += 0;
                            gold += 5;

                            // Write out changed stats
                            Console.WriteLine("Mining \t \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHunger: " + hunger + "\tWhisky: " + whisky + "\tGold: " + gold);
                            stateSwitch = 0;
                            break;

                        // If Morris is sleeping
                        case 2:
                            // Change the stats
                            sleepiness -= 10;
                            thirst += 1;
                            hunger += 1;
                            // whisky += 0;
                            // gold += 0;

                            // Write out changed stats
                            Console.WriteLine("Sleeping \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHunger: " + hunger + "\tWhisky: " + whisky + "\tGold: " + gold);
                            stateSwitch = 0;
                            break;

                        // If Morris is eating
                        case 3:
                            // Change the stats
                            sleepiness += 5;
                            thirst -= 5;
                            hunger -= 20;
                            // whisky += 0;
                            gold -= 2;

                            // Write out changed stats
                            Console.WriteLine("Eating \t \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHunger: " + hunger + "\tWhisky: " + whisky + "\tGold: " + gold);
                            stateSwitch = 0;
                            break;

                        // If Morris is drinking
                        case 4:
                            // Change the stats
                            sleepiness += 5;
                            thirst -= 15;
                            hunger -= 1;
                            whisky -= 1;
                            // gold -= 0;

                            // Write out changed stats
                            Console.WriteLine("Drinking \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHunger: " + hunger + "\tWhisky: " + whisky + "\tGold: " + gold);
                            stateSwitch = 0;
                            break;

                        // If Morris is shopping (for whisky)
                        case 5:
                            // Change the stats
                            sleepiness += 5;
                            thirst += 1;
                            hunger += 1;
                            whisky += 1;
                            gold -= 1;

                            // Write out changed stats
                            Console.WriteLine("Shopping \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHunger: " + hunger + "\tWhisky: " + whisky + "\tGold: " + gold);
                            stateSwitch = 0;
                            break;

                        // If none of the above
                        default:
                            Console.WriteLine("Error.");
                            break;
                    }
                }
            }

            // If Morris survives
            if (alive) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSurvived!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nTotal score:");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($" {gold} gold");
            }


            // Wait for input
            Console.ReadKey();
        }
    }
}