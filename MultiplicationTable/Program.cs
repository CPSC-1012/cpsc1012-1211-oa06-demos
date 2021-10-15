/*  Purpose:    Display a multiple table of the numbers 1 to 9
 *  
 *  Inputs:     N/A
 *  
 *  Outputs:    A multiplication table for the numbers 1 to 9
 *  
 *  Algorithm:  1) Display a welcome message
 *              2) For num2 ranging from 1 through 9 do the following:
 *                      Display num2 follow by 3 spaces
 *                 End For
 *                 Display a newline
 *                 
 *                 For num1 ranging from 1 through 9 do the following:
 *                      Display num1 follow by 3 spaces
 *                      For num2 ranging from 1 through 9 do the following:
 *                          Calculate 
 *                              multiplicationResult = num1 * num2
 *                          Display multiplicationResult follow 3 spaces
 *                      End For
 *                      Display a new line
 *                 End For
 *                 
 * */
using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("This program displays a Multiplication Table of the numbers 1 through 9.");
            /*
             *     For num2 ranging from 1 through 9 do the following:
 *                      Display num2 follow by 3 spaces
 *                 End For
 *                 Display a newline
 *                 
 *                 For num1 ranging from 1 through 9 do the following:
 *                      Display num1 follow by 3 spaces
 *                      For num2 ranging from 1 through 9 do the following:
 *                          Calculate 
 *                              multiplicationResult = num1 * num2
 *                          Display multiplicationResult follow 3 spaces
 *                      End For
 *                      Display a new line
 *                 End For
             */
            for (int num2 = 1; num2 <= 9; num2++ )
            {
                if (num2 == 1)
                {
                    Console.Write($"{num2,8}");
                }
                else
                {
                    Console.Write($"{num2,4}");
                }
                
            }
            Console.WriteLine();

            for (int num1 = 1; num1 <= 9; num1++)
            {
                Console.Write($"{num1,-4}");
                for (int num2 = 1; num2 <= 9; num2++)
                {
                    double multiplicationResult = num1 * num2;
                    Console.Write($"{multiplicationResult,4}");
                }

                Console.WriteLine();
            }
        }
    }
}
