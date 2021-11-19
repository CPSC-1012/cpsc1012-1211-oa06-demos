using System;

namespace ArrayProblems2Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt and read the number of values and range of values
            int numberCount;
            int minValue;
            int maxValue;
            int[] numberArray;

            Console.WriteLine("This program generates winning lotto numbers.");
            Console.Write("How many numbers to generate? ");
            numberCount = int.Parse(Console.ReadLine());
            Console.Write("What is the minimum number to generate? ");
            minValue = int.Parse(Console.ReadLine());
            Console.Write("What is the maximum number to generate? ");
            maxValue = int.Parse(Console.ReadLine());

            // Generate the random number values 
            numberArray = GenerateRandomNumbers(numberCount, minValue, maxValue);

            // Display the results
            DisplayResult(numberArray);
        }

        static void DisplayResult(int[] numberArray)
        {
            Console.Write("Your lucky numbers are: ");
            foreach(int number in numberArray)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

        static int[] GenerateRandomNumbers(int numberCount, int minValue, int maxValue)
        {
            int[] numberArray = new int[numberCount];
            Random rand = new Random();
            for (int index = 0; index < numberArray.Length; )
            {
                // Generate a random number between minValue and maxValue
                int randomNumber = rand.Next(minValue, maxValue + 1);
                // Add the number to the array if it is NOT a duplicate
                if (IsNumberInArray(numberArray, numberCount, randomNumber) == false)
                {
                    numberArray[index] = randomNumber;
                    index++;
                }

            }
            Array.Sort(numberArray);

            return numberArray;
        }

        static bool IsNumberInArray(int[] numberArray, int arrayCount, int searchValue)
        {
            bool found = false;

            for (int index = 0; index < arrayCount; index++)
            {
                if (numberArray[index] == searchValue)
                {
                    found = true;
                    index = arrayCount;
                }
            }

            return found;
        }
    }
}
