using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Hi";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter Guess: ");
                    guess = Console.ReadLine();
                    guessCount++;

                    if (guess == secretWord)
                    {
                        Console.WriteLine("You win!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong guess, try again.");
                    }
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.WriteLine("You lost!");
            }

            Console.ReadLine();
        }
    }
}
