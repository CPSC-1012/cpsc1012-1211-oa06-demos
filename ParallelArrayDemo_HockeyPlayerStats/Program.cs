using System;

namespace ParallelArrayDemo_HockeyPlayerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the maximum number of hockey players to track
            const int MaxPlayers = 23;
            // Declare and create a new string array for hockey player names
            string[] hockeyPlayerNameArray = new string[MaxPlayers];
            // Declare and create a new int array for hockey player points
            int[] hockeyPlayerPointArray = new int[MaxPlayers];
            // Declare a variable to track the current number of players
            int playerCount = 0;
            // Define the menu choice to exit the program
            const int ExitProgramChoice = 99;
            // Declare a variable to track the menuChoice
            int menuChoice;

            // Do the following:
            do
            {
                // Display Menu
                Console.WriteLine("Hockey Player Stats");
                Console.WriteLine("-------------------");
                Console.WriteLine(" 1. Add Player");
                Console.WriteLine(" 2. List Players");
                Console.WriteLine("99. Exit Program");
                Console.Write("Enter your menu choice:");

                // Process menu choice
                menuChoice = int.Parse(Console.ReadLine());
                switch(menuChoice)
                {
                    case 1: // Add Player
                        {
                            //Console.WriteLine("Add Player");
                            playerCount = AddPlayer(hockeyPlayerNameArray, hockeyPlayerPointArray, playerCount);
                        }
                        break;
                    case 2: // List Players
                        {
                            //Console.WriteLine("List Players");
                            ListPlayers(hockeyPlayerNameArray, hockeyPlayerPointArray, playerCount);
                        }
                        break;
                    case 99: // Exit Program
                        {
                            Console.WriteLine("Exit Program");
                        }
                        break;
                    default:    // Invalid Menu Choice
                        {
                            Console.WriteLine("Invalid menu choice");
                        }
                        break;
                }

            } while (menuChoice != ExitProgramChoice);            

        }

        static int AddPlayer(string[] nameArray, int[] pointArray, int arraySize)
        {
            int playerCount = 0;

            // Prompt and read in the player name
            Console.Write("Enter hockey player name: ");
            nameArray[arraySize] = Console.ReadLine();
            // Prompt and read in the player points
            Console.Write("Enter hockey player points: ");
            pointArray[arraySize] = int.Parse(Console.ReadLine());
            // Increment arraySize
            arraySize++;
            // Set playerCount to arraySize
            playerCount = arraySize;

            return playerCount;
        }

        static void ListPlayers(string[] nameArray, int[] pointArray, int arraySize)
        {
            if (arraySize == 0)
            {
                Console.WriteLine("There are no hockey players in the system.");
            }
            else
            {
                /*      123456789012345678901234567 123456
                 *      Player Name (27)            Points (6)
                 *      -----------                 ------
                 *      Ryan Nugent-Hopkins             18
                 *      
                 * */
                Console.WriteLine($"{"Player Name",-27} {"Points",6}");
                Console.WriteLine($"{"-----------",-27} {"------",6}");
                for (int index = 0; index < arraySize; index++)
                {
                    Console.WriteLine($"{nameArray[index],-27} {pointArray[index],6}");
                }
            }
            
        }
    }
}
