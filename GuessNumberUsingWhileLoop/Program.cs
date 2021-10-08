using System;

namespace GuessNumberUsingWhileLoop
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

            // Prompt the user to guess the correct number
            Console.Write("Enter your guess (1-100): ");
            int guessNumber = int.Parse(Console.ReadLine());

            // While guessNumber != randomNumber
            //      Display a message indicating if guessNumbers it too high or too low
            //      Prompt and read another guess number
            while (guessNumber != randomNumber)
            {
                if (guessNumber > randomNumber)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else
                {
                    Console.WriteLine("Your guess is too low");
                }
                Console.Write("Enter your guess (1-100):");
                guessNumber = int.Parse(Console.ReadLine());
            }
            // Display a message they got the correct answer
            Console.WriteLine("You guess the correct number.");

        }
    }
}
