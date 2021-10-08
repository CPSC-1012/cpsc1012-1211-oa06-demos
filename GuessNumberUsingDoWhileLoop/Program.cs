using System;

namespace GuessNumberUsingDoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);

            // Display a welcome message
            Console.WriteLine($"This program generates a random number {randomNumber} for you to guess.");

            int guessNumber;
            do
            {
                // Prompt the user to guess the correct number
                Console.Write("Enter your guess: ");
                guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("You guessed the correct number.");
                }
                else if (guessNumber > randomNumber)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else
                {
                    Console.WriteLine("Your guess is too low");
                }

            } while (guessNumber != randomNumber);

        }
    }
}
