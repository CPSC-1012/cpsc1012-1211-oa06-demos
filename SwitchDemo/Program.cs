using System;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for inputs
            //const char ExitProgramChoice = 'x';
            //char menuChoice;
            const int ExitProgramChoice = 0;
            int menuChoice;

            do
            {
                // Display a menu of options for the user to choose from
                const string MainMenu ="Please enter: \n"
                       + "1 - Print Multiplication Table, or\n"
                       + "2 - Play Dice Game, or \n"
                       + "3 - Play Rock-Paper-Scissor Game, or\n"
                       + "0 - Exit program.\n";
                menuChoice = PromptForIntegerPositiveOrZero(MainMenu);

                switch (menuChoice)
                {
                    //case 'a':
                    case 1:
                        {
                            // Multiplication Table 
                            Console.WriteLine("Multiplication Table");
                        }
                        break;
                    //case 'b':
                    case 2:
                        {
                            // Dice Game
                            Console.WriteLine("Dice Game");
                        }
                        break;
                    //case 'c':
                    case 3:
                        {
                            // Rock-Paper-Scissor Game
                            Console.WriteLine("Rock-Paper-Scissor Game");
                        }
                        break;
                    //case 'x':
                    case 0:
                        break;
                    default:
                        Console.WriteLine($"Invalid menu choice {menuChoice}");
                        break;
                }
            } while (menuChoice != ExitProgramChoice);
            Console.WriteLine("Good-bye");
            


        }

        static int PromptForIntegerPositiveOrZero(string prompt)
        {
            int intValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(prompt);
                try
                {
                    intValue = int.Parse(Console.ReadLine());
                    if (intValue >= 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input. You must enter a positive or zero number.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return intValue;
        }
    }
}
