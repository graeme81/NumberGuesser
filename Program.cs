using System;

//namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Graeme Cameron";
            bool play = true;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            Console.WriteLine("What is your name?");
            string player = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello {0}, lets play a game.", player);

            while (play)
            {

                //int numToGuess = 7;
                Random num = new Random();
                int numToGuess = num.Next(10);

                int guessed = 0;

                while (guessed != numToGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("Guess a number between 1 - 10:");
                    Console.ResetColor();
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guessed))
                    {
                        Console.WriteLine("Please Enter a NUMBER!");
                        continue;
                    }

                    //guessed = Int32.Parse(input);

                    if (guessed != numToGuess)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong, Try again");
                    }

                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Well done {0}, Good Guessing", player);
                Console.ResetColor();

                Console.WriteLine("Hey {0}, Do you want to play again? y/n", player);
                string again = Console.ReadLine();

                if(again != "y")
                {
                    play = false;
                }


            }
                Console.WriteLine("Press key to Exit...");
                Console.ReadKey();
        }
    }


}
