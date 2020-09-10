using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morris_the_Miner_Alt1 {
    class Program {
        static void Main(string[] args) {
            int sleepiness = 0, thirst = 0, hungry = 0, whisky = 0, gold = 0;

            string state = "Mining";

            bool alive = true;

            for (int i = 0; i < 1000; i++) {

                if (alive) {

                    if (sleepiness > 100 || thirst > 100 || hungry > 100 || whisky > 10) {

                        alive = false;

                        Console.WriteLine("\n\t\t Morris R.I.P \n");

                    }

                    // If he is told to mine & is still alive
                    if (state == "Mining" && alive) {

                        sleepiness += 5;

                        thirst += 5;

                        hungry += 5;

                        gold += 5;

                        Console.WriteLine("Mining \t \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHungry: " + hungry + "\tWhisky: " + whisky + "\tGold: " + gold);

                        if (sleepiness >= 95) {
                            state = "Sleeping";
                        }
                        else if (whisky < 1) {
                            state = "Shop4Whisky";
                        }
                        else if (thirst >= 80) {
                            state = "Drink";
                        }
                        else if (hungry >= 80) {
                            state = "Eat";
                        }
                    }

                    // If he is told to sleep & still alive
                    if (state == "Sleeping" && alive && hungry < 95 && thirst < 95) {

                        sleepiness -= 10;

                        thirst += 1;

                        hungry += 1;

                        Console.WriteLine("Sleeping \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHungry: " + hungry + "\tWhisky: " + whisky + "\tGold: " + gold);

                        state = "Mining";
                    }

                    // If he is told to eat & still alive
                    if (state == "Eat" && alive && thirst < 100) {

                        sleepiness += 5;

                        thirst -= 5;

                        hungry -= 20;

                        gold -= 2;

                        Console.WriteLine("Eating \t \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHungry: " + hungry + "\tWhisky: " + whisky + "\tGold: " + gold);

                        state = "Mining";
                    }

                    // If he is told to shop for whisky & is still alive
                    if (state == "Shop4Whisky" && alive) {

                        sleepiness += 5;

                        thirst += 1;

                        hungry += 1;

                        whisky += 1;

                        gold -= 1;

                        Console.WriteLine("Shopping4Whisky " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHungry: " + hungry + "\tWhisky: " + whisky + "\tGold: " + gold);

                        state = "Mining";
                    }

                    // If he is told to drink & is still alive
                    if (state == "Drink" && alive) {

                        sleepiness += 5;

                        thirst -= 15;

                        hungry -= 1;

                        whisky -= 1;

                        Console.WriteLine("Drinking \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHungry: " + hungry + "\tWhisky: " + whisky + "\tGold: " + gold);

                        state = "Mining";
                    }
                }
            }

            // If he survived 1000 rounds
            if (alive == true) {
                Console.WriteLine("Survived!");
            }


            // Wwait for input
            Console.ReadKey();
        }
    }
}

