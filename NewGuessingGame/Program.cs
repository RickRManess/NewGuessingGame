using System;

namespace NewGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int guess;
            int secret;
            int counter;

            // Introduction Text
            DisplayWelcomeScreen();

            //Secret Number Created
            secret = rand.Next(100);


            //UserGuess Input
            //Game Loop With Count Limit 10 
            for (int i = 0; i < 10; i++)
            {

                guess = Int32.Parse(Console.ReadLine());

                if (secret > guess)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    if (secret < guess)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Great Job!!! You Guessed it!!");

                        DisplayWelcomeScreen();
                        secret = rand.Next(100);       //reinitialize game
                       
                    }

                }
            }
            Console.WriteLine("You Lose");
        }

        static void DisplayWelcomeScreen()
        {

            Console.Clear();
            Console.WriteLine("Lets Play a Game....");
            Console.WriteLine("Pick a number between 1 and 100");
        }


    }
}
