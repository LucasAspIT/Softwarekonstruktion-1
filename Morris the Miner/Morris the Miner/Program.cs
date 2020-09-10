using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morris_the_Miner {
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

                    if (state == "Mining" && alive) {

                        sleepiness += 5;

                        thirst += 5;

                        hungry += 5;

                        gold += 5;

                        Console.WriteLine("Mining \t \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHungry: " + hungry + "\tWhisky: " + whisky + "\tGold: " + gold);

                        if (sleepiness >= 90) {
                            state = "Sleeping";
                        }
                        else if (hungry >= 90) {
                            state = "Eat";
                        }
                        else if (thirst >= 90) {
                            state = "Drink";
                        }
                        else if (whisky < 3) {
                            state = "Shop4Whisky";
                        }
                    }
                    if (state == "Sleeping" && alive) {

                        sleepiness -= 10;

                        thirst += 1;

                        hungry += 1;

                        Console.WriteLine("Sleeping \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHungry: " + hungry + "\tWhisky: " + whisky + "\tGold: " + gold);

                        if (sleepiness <= 30) {
                            state = "Mining";
                        }
                        else if (hungry > 90) {
                            state = "Eat";
                        }
                    }

                    if (state == "Eat" && alive) {

                        sleepiness += 5;

                        thirst -= 5;

                        hungry -= 20;

                        gold -= 2;

                        Console.WriteLine("Eating \t \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHungry: " + hungry + "\tWhisky: " + whisky + "\tGold: " + gold);

                        if (hungry < 70) {
                            state = "Mining";
                        }
                    }

                    if (state == "Shop4Whisky" && alive) {

                        sleepiness += 5;

                        thirst += 1;

                        hungry += 1;

                        whisky += 1;

                        gold -= 1;

                        Console.WriteLine("Shopping4Whisky " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHungry: " + hungry + "\tWhisky: " + whisky + "\tGold: " + gold);

                        if (whisky >= 9) {
                            state = "Mining";
                        }
                        else if (sleepiness > 90) {
                            state = "Sleeping";
                        }
                    }

                    if (state == "Drink" && alive) {

                        sleepiness += 5;

                        thirst -= 15;

                        hungry -= 1;

                        whisky -= 1;

                        Console.WriteLine("Drinking \t " + "\tSleepiness: " + sleepiness + "\t\tThirst: " + thirst + "\tHungry: " + hungry + "\tWhisky: " + whisky + "\tGold: " + gold);

                        if (thirst < 70) {
                            state = "Mining";
                        }
                    }
                }
            }
            if (alive == true) {
            Console.WriteLine("Survived!");
            }

            Console.ReadLine();
        }
    }
}

