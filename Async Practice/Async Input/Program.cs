using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace AsyncStuff {
    class Program {
        static void Main(string[] args) {

            // Get user inputs
            UserInput();

            // Use user inputs to makee breakfast
            PrepareBreakfast(amntBacon);

            // Wait for input
            Console.ReadKey();
        }


        /// <summary>
        /// Asks the user how much breakfast they want
        /// </summary>
        static void UserInput() {

            // Variables for user input
            int amntEggs, amntBacon, amntToast;

            // Ask the user for the required inputs
            Console.WriteLine("It's time to cook breakfast!\n");

            Console.Write("How many eggs do you want?: ");
            amntEggs = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("How many bacon strips do you want?: ");
            amntBacon = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("How many pieces of toast do you want?: ");
            amntToast = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }

        /// <summary>
        /// Create the breakfast from the user inputs. <para />
        /// Async is used to make eggs, bacon and toast at the same time.
        /// </summary>
        static async void PrepareBreakfast(int amntBacon) {

            // Create a stopwatch
            Stopwatch watch = new Stopwatch();
            // Start the stopwatch
            watch.Start();

            // Declare ints for breakfast
            // int eggs;
            // int bacon;
            // int toast;

            // Create 3 cooking tasks
            Task<int> eggys = new Task<int>(CookEggs);
            Task<int> toasty = new Task<int>(PrepareToast);
            Task<int> bacony = new Task<int>(CookBacon());

            // Start the 3 tasks
            eggys.Start();
            toasty.Start();
            bacony.Start();

            // Set ints to values from various breakfast methods
            await eggys;
            await bacony;
            await toasty;

            // Wait for when all tasks are completed
            await Task.WhenAll(eggys, toasty, bacony);


            // Stop the stopwatch
            watch.Stop();
            // Write out the stopwatch's elapsed time
            // Format the output to a maximum of 2 decimals
            Console.WriteLine($"\nIt took {watch.Elapsed.TotalSeconds.ToString(String.Format("0.00", watch))} seconds to cook a full breakfast.");
        }


        /// <summary>
        /// Goes through the entire process of cooking bacon
        /// </summary>
        static int CookBacon(int amntBacon) {
            int bacon = amntBacon;

            Console.WriteLine("Heating the pan");
            // Wait 5000 milliseconds
            Thread.Sleep(5000);
            Console.WriteLine("Putting bacon on pan");
            Thread.Sleep(5000);
            Console.WriteLine("Putting bacon on plate");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bacon is ready!");
            Console.ForegroundColor = ConsoleColor.Gray;

            return bacon;
        }


        /// <summary>
        /// Goes through the process of making peanut butter toast
        /// </summary>
        static int PrepareToast() {
            int toastSlices = 3;

            Console.WriteLine($"Cutting {toastSlices} slices of bread");
            Thread.Sleep(3000);
            Console.WriteLine("Heat up toaster");
            Thread.Sleep(5000);
            Console.WriteLine("Put bread into toaster");
            Thread.Sleep(5000);
            Console.WriteLine("Toast is done");
            Console.WriteLine("Peanut butter jelly time");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Peanut butter toast is done!");
            Console.ForegroundColor = ConsoleColor.Gray;

            return toastSlices;
        }


        /// <summary>
        /// Goes through the process of cooking eggs
        /// </summary>
        static int CookEggs() {
            int eggs = 2;

            Console.WriteLine("Heat up water");
            Thread.Sleep(3000);
            Console.WriteLine("Put eggs into boiling water");
            Thread.Sleep(3000);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Eggs are done!");
            Console.ForegroundColor = ConsoleColor.Gray;

            return eggs;
        }


    }
}