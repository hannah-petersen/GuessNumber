using System;

// Namespace
namespace FirstProject
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
           
            while (true)
            {
                // Set correct number
                //int correctNumber = 7;
                // Create a new Random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                // Init guess var
                int guess = 0;
                // Ask for a number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {

                    string UserGuess = Console.ReadLine();
                    if (!int.TryParse(UserGuess, out guess))
                    {
                        PrintColourMessage(ConsoleColor.Red, "Please enter an actual number");
                        //Console.WriteLine("Please enter an actual number");
                        continue;

                    }

                    guess = Convert.ToInt32(UserGuess);
                    if (guess != correctNumber)
                        PrintColourMessage(ConsoleColor.Red, "It is not right, please try again!");  
                    
                }
                PrintColourMessage(ConsoleColor.Yellow, "CORRECT, you are smart!");
                
                // ask if user want to play again
                Console.WriteLine("Do you want to play again? Input y to play again");
                string Answer = Console.ReadLine().ToLower();
                if (Answer != "y")
                    break;
            }
        }
        static void GetAppInfo()
        {
            // START HERE//
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Hannah Petersen";

            //change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthor);

            // reset the text colour
            Console.ResetColor();
        }
        static void GreetUser() 
        {
            // Ask users name
            Console.WriteLine("What is your name?");
            // Get user input
            string Username = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game ", Username);
        }
        static void PrintColourMessage(ConsoleColor TheColour, string TheMessage) 
        {
            Console.ForegroundColor = TheColour;
            Console.WriteLine(TheMessage);
            Console.ResetColor();
        }
    }
}