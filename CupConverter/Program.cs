using System;

namespace CupConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double cups;
            double ounces;

            // Get the number of cups
            cups = GetCups();
            // Convert cups to fluid ounces
            ounces = CupsToOunces(cups);

            // Display the results
            DisplayResults(cups, ounces);

        }

        /// <summary>
        /// Prompt, read, and return the number of cups
        /// </summary>
        /// <returns>the number of cups</returns>
        static double GetCups()
        {
            double numCups = 0;
            // Prompt for the number of cups from the user
            Console.WriteLine("This program converts measurements in cups to fluid ounces.");
            Console.WriteLine("For your reference the formuls is: ");
            Console.WriteLine("     1 cup = 8 fluid ounces");
            Console.Write("Enter the number of cups: ");
            //numCups = double.Parse(Console.ReadLine());
            bool validInput = double.TryParse(Console.ReadLine(), out numCups);
            while (!validInput)
            {
                Console.WriteLine("Invalid input value. Try again.");
                Console.Write("Enter the number of cups: ");
                validInput = double.TryParse(Console.ReadLine(), out numCups);
            }

            return numCups;
        }

        /// <summary>
        /// Converts cups to fluild ounces.
        /// </summary>
        /// <param name="numCups">the number of cups to convert</param>
        /// <returns>the converted fluid ounces value</returns>
        static double CupsToOunces(double numCups)
        {
            double numOunces = 0;
            
            numOunces = numCups * 8;
            
            return numOunces;
        }

        /// <summary>
        /// Print a message showing the cups to ounces conversion result.
        /// </summary>
        /// <param name="cups">the number of cups</param>
        /// <param name="ounces">the number of fluid ounces</param>
        static void DisplayResults(double cups, double ounces)
        {
            Console.WriteLine($"{cups} cups equal {ounces} fluid ounces.");
        }

    }
}
