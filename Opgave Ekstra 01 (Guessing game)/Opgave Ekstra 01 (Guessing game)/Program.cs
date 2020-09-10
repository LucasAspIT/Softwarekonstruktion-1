using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Ekstra_01__Guessing_game_ {
    class Program {
        static void Main(string[] args) {

        ResetProgram:

            // Initiate random number generator
            Random numberGenerator = new Random();
            // Create an int and use the random number generator to store an int value between 1-20 (The first number is inclusive and the second number is exclusive)
            int randomNumber = numberGenerator.Next(1, 21);

            // Variable declaration to keep track of when the game is over (whether by user guessing the number or running out of tries) & their current guess & their total amount of guesses
            bool gameWin = false;
            bool gameLost = false;
            bool gameExit = false;
            int userCurrentGuess;
            int userTotalGuesses = 0;


            // Increase console width slightly more than default to fit introduction below all on one line
            Console.WindowWidth = 131;

            // Introduction for the user about what the program does and the rules
            Console.WriteLine("Welcome to this simple little game.");
            Console.WriteLine("In this game, a number between 1-20 will randomly be selected behind-the-scenes, and you have to guess which one with only 6 tries.\n");
            Console.WriteLine("Press any key to continue.");

            // Wait for input & clear console once input is received
            Console.ReadKey();
            Console.Clear();


        // A label used to return to the game if an error ocurred
        GameStart:

            // Tries to catch errors during the while loop where the user can input incorrect things
            try {

                // As long as the user hasn't guessed the correct number & the user hasn't used up all their chances then run the 'while loop'
                while (gameWin == false && gameLost == false && gameExit == false) {
                    // Inform how many guesses have been made
                    Console.WriteLine($"Total guesses made: {userTotalGuesses}.\n");

                    // Each time the user needs to make a guess, ask them to do so
                    Console.Write("Guess a number: ");

                    // Each time they make a guess, save the guess as an int to compare and check if it's correct or not in the 'if statement' further down
                    userCurrentGuess = int.Parse(Console.ReadLine());

                    // Keep track of total guesses by incrementing it by 1 per user input
                    userTotalGuesses++;

                    // Clear the console of text
                    Console.Clear();


                    // If the user correctly guesses the number then end the 'while loop' and:
                    if (userCurrentGuess == randomNumber) {
                        // Disables the while loop when winning the game
                        gameWin = true;

                        // Change text color to green and inform the user they won & set the text color to white again
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You guessed the correct number and won!\n");
                        Console.ForegroundColor = ConsoleColor.White;


                        // If it takes 1 try, then spell it 'try' when informing the user how many guesses it took
                        if (userTotalGuesses == 1) {
                            Console.WriteLine($"It took you {userTotalGuesses} try to find the correct number.\n");
                        }
                        // If it takes 2 or more tries, spell it 'tries' when informing the user how many guesses it took
                        else {
                            Console.WriteLine($"It took you {userTotalGuesses} tries to find the correct number.\n");
                        }


                        // Inform them the game can be reset with the press of a key
                        Console.WriteLine("Press any key to restart the game.");
                    }

                    // If the user uses all their guesses & the guess is within the range of 1-20 then end the 'while loop' and:
                    else if (userTotalGuesses == 6 && userCurrentGuess >= 1 && userCurrentGuess <= 20) {
                        // Disables the while loop when losing the game
                        gameLost = true;

                        // Inform the user they guessed wrong & inform them of the correct answer
                        Console.WriteLine("Wrong guess!\n");
                        Console.WriteLine($"You've now run out of guesses. The correct answer was: {randomNumber}\n");

                        // Change text color to red & inform the user they lost & set text color back to white
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You've lost the game!\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        // Inform them the game can be reset with the press of a key
                        Console.WriteLine("Press any key to restart the game.");
                    }

                    // If the user guesses wrong and the guess is greater than the correct number and equal to or lesser than 20 (we know it can't be 0 or lesser than that because the guess was greater
                    // than the correct number which is between 1-20) and:
                    else if (userCurrentGuess > randomNumber && userCurrentGuess <= 20) {
                        // In red text inform the user they guessed wrong & in white text inform the number they input is greater than the correct number
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong guess!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("The number you guessed is greater than the correct number.\n");
                        Console.WriteLine("Press any key to continue.");

                        // Wait for input & clear console once input is received
                        Console.ReadKey();
                        Console.Clear();
                    }

                    //If the user guesses wrong and the guess is lesser than the correct number and equal to or greater than 0 (we know it can't be 21 or greater than that because the guess was lesser 
                    // than the correct number which is between 1-20) and:
                    else if (userCurrentGuess < randomNumber && userCurrentGuess >= 1) {
                        // In red text inform the user they guessed wrong & in white text inform the number they input is lesser than the correct number
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong guess!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("The number you guessed is less than the correct number.\n");
                        Console.WriteLine("Press any key to continue.");

                        // Wait for input & clear console once input is received
                        Console.ReadKey();
                        Console.Clear();
                    }

                    // If the user guesses equal to or lesser than 0 & if the user guesses equal to or above 21 then decrease the total amount of guesses by 1 as the guess didn't count & change text to 
                    // red & error and ask them to guess a number between 1-20 & change text back to white & wait for input & clear console
                    else {
                        // Decrease total amonut of guesses because the guess didn't count
                        userTotalGuesses--;

                        // Change text to red and error
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error. Please guess a number between 1-20.\n");

                        // Set text back to white & waits for an input & clear console once input is received
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press any key to return to the game.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

            }
            // Catches the error FormatException if the user tries to input a string when asked for an int number & returns an error message
            catch (FormatException formatExceptionError) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + formatExceptionError.Message);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
                Console.Clear();

                // Returns to the 'while loop' it was running before the error
                goto GameStart;
            }
            // Catches the error OverflowException if the user types a number smaller or bigger than the Int32 range & returns an error message
            catch (OverflowException overflowExceptionError) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + overflowExceptionError.Message);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
                Console.Clear();

                // Returns to the 'while loop' it was running before the error
                goto GameStart;
            }

            // After the game is won or lost or an error occurs & wait for user input so the program doesn't close immediately
            Console.ReadKey();
            Console.Clear();

            // Resets the application by returning to the start
            goto ResetProgram;
        }
    }
}