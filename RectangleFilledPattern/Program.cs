/*  Purpose:    Draw a rectangle box with a user specified number of rows and columns using 
 *              a user specified filled character.
 *              
 *  Inputs:     rows
 *              columns
 *              filledCharacter
 * 
 *  Output:     A rectangle box draw on the screen with filledCharacter of rows and columns
 * 
 *  Algorithm:  1) Display a welcome message
 *              2) Prompt and read in the the numbers of rows and columns and filledCharacter
 *              3) For row ranging from 1 through rows do the following:
 *                      For column ranging from 1 through columns do the following:
 *                          Display a single filledCharacter
 *                      End For
 *                      Display a new line
 *                 End For
 * */
using System;

namespace RectangleFilledPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for inputs 
            int rows,       // number of rows to display
                columns;    // number of columns for each row to display
            char filledChar;    // the character used to print the rectangle

            // Display a welcome message
            Console.WriteLine("This program display rectangle on the screen");
            // Prompt and read in the the numbers of rows and columns and filledCharacter
            Console.Write("Enter the number of rows to print: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns to print: ");
            columns = int.Parse(Console.ReadLine());
            Console.Write("Enter the character used to print the rectange: ");
            //filledChar = char.Parse(Console.ReadLine());
            filledChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            /*  For row ranging from 1 through rows do the following:
 *                      For column ranging from 1 through columns do the following:
 *                          Display a single filledCharacter
 *                      End For
 *                      Display a new line
 *                 End For
             * */
            for (int currentRow = 1; currentRow <= rows; currentRow++)
            {
                for (int currrentColumn = 1; currrentColumn <= columns; currrentColumn++)
                {
                    Console.Write(filledChar);
                }
                Console.WriteLine();
            }


        }
    }
}
