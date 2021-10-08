using System;

namespace ForLoop1Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for the number of times to print the message
            //Console.Write("How many times do you want to print the message?");
            //int printTotal = int.Parse(Console.ReadLine());
            //for (int counter = 1; counter <= printTotal; counter++ )
            //{
            //    Console.WriteLine($"I will not play games during class #{counter}.");
            //}

            // Countdown from 10 to 1. Here is a sample run:
            //  10 9 8 7 6 5 4 3 2 1 ***blast off*** (beep)
            //for (int counter = 10; counter > 0; counter--)
            //{
            //    // Print the current counter value
            //    Console.Write($"{counter} ");
            //    // Pause the program for 1000 millisecond (1 second)
            //    System.Threading.Thread.Sleep(1000);
            //}
            //Console.WriteLine("*** Blast Off ***");
            //Console.Beep();

            // Display all the even number from 1 to 100
            for (int number = 1; number <= 100; number++) {
                // Determine if the current number is even
                if (number % 2 == 0)
                {
                    // Print the even number
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine();

            // Display all the even number from 2 to 100 by incrementing by 2
            for (int number = 2; number <= 100; number += 2)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
         
        }
    }
}
