using System;

namespace FahrenheitToCelsius
{
    // This program converts a input temperature in fahrenheit to celsius.
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Display a welcome message 
            Console.WriteLine("This program converts a temperature from Fahrenheit to Celsius");

            // Step 2: Prompt and read the fahrenheit temperature
            Console.Write("Enter a degree in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            // Step 3: Convert the temperature from fahrenheit to celuis using the formula:
            //      celsius = (5 / 9) * (fahrenheit - 32)
            double celsius = (5.0 / 9) * (fahrenheit - 32);

            // Step 4: Display the tempature in celsius
            Console.WriteLine($"Fahrenheit {fahrenheit:F1} is {celsius:F1} celsius.");

        }
    }
}
