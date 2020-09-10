using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_8._1 {
    class Program {
        static void Main(string[] args) {
            /*
                        // Checking quiz answers
                        int a = 2;
                        int b = 4;
                        int questionNumber = 1;

                        Console.WriteLine($"Question {questionNumber++}");
                        if (a == b || a > 0) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.WriteLine($"Question {questionNumber++}");
                        if (a + b > 0 && a > 0) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.WriteLine($"Question {questionNumber++}");
                        if (a != 5 && a + b > 0) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.WriteLine($"Question {questionNumber++}");
                        if ((true || false) && a > b) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.WriteLine($"Question {questionNumber++}");
                        if (3 > 5 && true || a == b) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.WriteLine($"Question {questionNumber++}");
                        if (b > a && true || false || b > 4) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.WriteLine($"Question {questionNumber++}");
                        if (b < 4 && a < b || a + b > 4 && true) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.WriteLine($"Question {questionNumber++}");
                        if (true && true || false) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.WriteLine($"Question {questionNumber++}");
                        if (true && false && true) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.WriteLine($"Question {questionNumber++}");
                        if (true || false || false) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.WriteLine($"Question {questionNumber++}");
                        if (true && false) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.WriteLine($"Question {questionNumber++}");
                        if (a == 3 && b > 4 || a + 3 > b) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.WriteLine($"Question {questionNumber++}");
                        if (a > b && b < a && a + a == b) {
                            Console.WriteLine("true");
                        }
                        else {
                            Console.WriteLine("false");
                        }

                        Console.ReadLine();
            */

            //Initial declaration of variables for the quiz
            int quizCorrectAnswers = 13, quizUserCorrectAnswer = 0;
            bool userAnswer;

            // Introduction to the quiz and instructions
            Console.WriteLine("Welcome to this boolean algebra quiz.\n");
            Console.WriteLine("You're going to be represented with several statements.\n");
            Console.WriteLine("Choose whether you think the statement is true or false.\n\n");

            // An example of waht to do for the user
            Console.WriteLine("For example: ");
            Console.WriteLine("int a = 0;");
            Console.WriteLine("int b = 0;");
            Console.WriteLine("a == b;");
            Console.WriteLine("The above statement is correct, therefore the answer is: true\n\n");

            // Waits for the user to press a key so they can start the quiz & clears console
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();


            // Question 1
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            // Asks the question and saves the user answer as a bool
            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("a == b || a > 0");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            // If the user answered correctly, add +1 to the correct answers
            if (userAnswer == true) {
                quizUserCorrectAnswer++;
            }


            // Question 2
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("a + b > 0 && a > 0");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            if (userAnswer == true) {
                quizUserCorrectAnswer++;
            }


            // Question 3
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("a != 5 && a + b > 0");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            if (userAnswer == true) {
                quizUserCorrectAnswer++;
            }


            // Question 4
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("(true || false) && a > b");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            if (userAnswer == false) {
                quizUserCorrectAnswer++;
            }


            // Question 5
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("3 > 5 && true || a == b");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            if (userAnswer == false) {
                quizUserCorrectAnswer++;
            }


            // Question 6
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("b > a && true || false || b > 4");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            if (userAnswer == true) {
                quizUserCorrectAnswer++;
            }


            // Question 7
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("b < 4 && a < b || a + b > 4 && true");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            if (userAnswer == true) {
                quizUserCorrectAnswer++;
            }


            // Question 8
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("true && true || false");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            if (userAnswer == true) {
                quizUserCorrectAnswer++;
            }


            // Question 9
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("true && false && true");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            if (userAnswer == false) {
                quizUserCorrectAnswer++;
            }


            // Question 10
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("true || false || false");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            if (userAnswer == true) {
                quizUserCorrectAnswer++;
            }


            // Question 11
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("false && false");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            if (userAnswer == false) {
                quizUserCorrectAnswer++;
            }


            // Question 12
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("a == 3 && b > 4 || a + 3 > b");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            if (userAnswer == true) {
                quizUserCorrectAnswer++;
            }


            // Question 13
            Console.WriteLine("int a = 2;");
            Console.WriteLine("int b = 4;\n");

            Console.WriteLine("Is the following statement true or false?\n");
            Console.WriteLine("a > b && b < a && a + a == b");
            userAnswer = bool.Parse(Console.ReadLine());
            Console.Clear();

            if (userAnswer == false) {
                quizUserCorrectAnswer++;
            }





            // Add different ending color below depending on if you did great (green), okay (yellow), or bad (red).






            // Shows the user how many questions they got correct
            Console.WriteLine($"You got {quizUserCorrectAnswer} out of {quizCorrectAnswers} answers correct.");

            // Waits for a user input so the console doesn't close immediately
            Console.ReadKey();
        }
    }
}