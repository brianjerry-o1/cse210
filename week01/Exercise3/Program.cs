using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // A random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = 80;
            int guessCount = 0;

            Console.WriteLine("Welcome to the Guess My Number Game!");

            // Keep looping until correct value found           while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // number of guesses 
            Console.WriteLine($"It took you {guessCount} guesses.");

            // replay
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();

            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}