using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {

        // Entry Point Method
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Daniel Won";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            // Write out app info
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play the game!");

            // Set correct number
            int correctNumber = 1;

            // Init guess var
            int guess = 0;

            // Prompt user for a number
            Console.WriteLine("Guess a number between 1 and 10.");

            // Guess is incorrect
            while (guess != correctNumber)
            {
                // Get user's input
                string input = Console.ReadLine();

                // Make sure it's a number
                if(!int.TryParse(input, out guess))
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Not a number message
                    Console.WriteLine("That's not a number. Please enter a number.");

                    // Reset text color
                    Console.ResetColor();

                    // Keep going
                    continue;
                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if (guess != correctNumber)
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Wrong number message
                    Console.WriteLine("Wrong number! Please try again.");

                    // Reset text color
                    Console.ResetColor();
                }
            }

            // Output success message
            Console.ForegroundColor = ConsoleColor.Green;

            // Success message
            Console.WriteLine("You are right on the money!");

            // Reset text color
            Console.ResetColor();

        }
    }
}

