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
        start:
            Console.Clear();
            Console.WriteLine("Lets Play a Game....");
            Console.WriteLine("Pick a number between 1 and 100");

            //Secret Number Created
            secret = rand.Next(100);
            counter = 0;

            //UserGuess Input
            //Game Loop With Count Limit 10 
            while (counter< 10)
                {
                  
                guess = Int32.Parse(Console.ReadLine());

                    if (secret > guess)
                    {
                        Console.WriteLine("Too Low");
                    }
                    else if (secret < guess)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Great Job!!! You Guessed it!!");
                    goto start;
                    
                    }
                    counter++;
                }
            Console.WriteLine("You Lose");
            
                
        }   
    }
}
