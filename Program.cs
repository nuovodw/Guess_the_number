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
            GetAppInfo(); // see bottom of the page for details

            GreetUser(); 

            while (true)
            {

                // Set correct number
                // int correctNumber = 1;

                // Create a new Random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

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
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red,"That wasn't a number. Please use a number.");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number! Please try again.");
                    }
                }

                PrintColorMessage(ConsoleColor.Green, "You are right on the money!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer 
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")    
                {
                    return;

                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
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
        }

        static void GreetUser()
        {
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play the game!");
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Not a number message
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}

