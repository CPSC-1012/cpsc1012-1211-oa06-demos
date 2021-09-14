/*
 * Purpose:     Computes the area and volume of a cylinder
 * 
 * Inputs:      radius of cylinder
 *              length of cylinder
 * 
 * Algorithm:   1. Display a welcome message
 *              2. Prompt and read in the radius and length of the cylinder
 *              3. Compute the area and volume of the cylinder
 *              4. Display the computed area and volume of the cylinder
 *              
 * Outputs:     area of cylinder
 *              volume of cylinder
 * 
 * 
 * Test Plan:   Test Case               Test Data        Expected Results       Checked
 *              -------------------     ---------------- -----------------      -------
 *              small radius,length     radius: 5.5         area = 95.0311
 *                                      length: 12          volume = 1140.4
 *                                      
 *              large radius/length     radius: 75          area = 17,678.5714
 *                                      length: 100         volume = 1,757,857.1
 *                                      
 *              medium radius/length    radius: 20          area = 1,257.1429
 *                                      length: 25          volume = 31,428.6
 * 
 * */
using System;

namespace SSPE_Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("This program computes the area and volume of cylinder.");
            // Declare variables for inputs and outputs
            double radius;
            double length;
            double area;
            double volume;
            //double  radius,
            //        length,
            //        area,
            //        volume;
            //
            // Prompt and read in the radius
            Console.Write("Enter the radius of the cylinder: ");
            radius = double.Parse(Console.ReadLine());
            // Prompt and read in the length
            Console.Write("Enter the length of the cylinder: ");
            length = double.Parse(Console.ReadLine());

            // Compute the area of the cylinder using the formula:
            //  area = radius * radius * pi
            area = radius * radius * Math.PI;

            // Compute the volume of the cylinder using the formula:
            // volume = area * length
            volume = area * length;

            // Display the area and volume
            Console.WriteLine($"The area is {area:F4}");
            Console.WriteLine($"The volume is {volume:F1}");


        }
    }
}
