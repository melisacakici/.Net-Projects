using System;


namespace numberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Melisa Cakici";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            // Write app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            // Reset text color
            Console.ResetColor();

            // ask users name
            Console.WriteLine("Please enter your name: ");
            // get user input
            string input = Console.ReadLine();
            Console.WriteLine("Hello " + input);
            Console.WriteLine("Let's Play a Game!");

            // Set the number
            int theNumber = 8;

            // set the guess var
            int guess = 0;
            
            
            // while guess is not correct
            while( guess != theNumber)
            {
                Console.WriteLine("Guess a number from 1 to 10: ");
                // get users input
                string inputGuess = Console.ReadLine();
                guess = Int32.Parse(inputGuess);
                if(guess == theNumber)
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Green;

                    // Write app info
                    Console.WriteLine("Correct!");
                    // Reset text color
                    Console.ResetColor();
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Write app info
                    Console.WriteLine("Failed!");
                    // Reset text color
                    Console.ResetColor();
                }
            }

        }
    }
}
