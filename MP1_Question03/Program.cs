using System;

namespace MP1_Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the tax due for a given taxable income.");
            // Declare variables inputs (taxableIncome) and outputs (taxDue)
            double taxableIncome;
            double taxDue;
            // Prompt and read in the taxable income
            taxableIncome = PromptForDoubleValue("Enter the taxable income: ");
            // Call the TaxesOwned method and stored the return value in the taxDue variable
            taxDue = TaxesOwned(taxableIncome);
            // Print the Tax Due
            Console.WriteLine($"For an taxable income of {taxableIncome:C} the tax due is {taxDue:C} ");
        }

        static double TaxesOwned(double income)
        {
            double taxDue = 0;
            if (income <= 50000)
            {
                taxDue = 0.05 * income;
            }
            else if (income <= 100000)
            {
                taxDue = 2500 + 0.07 * (income - 50000);
            }
            else
            {
                taxDue = 6000 + 0.09 * (income - 100000);
            }

            return taxDue;
        }

        static double PromptForDoubleValue(string prompt)
        {
            double doubleValue = 0;
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write(prompt);
                    doubleValue = double.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input value. You must enter a integer value.");
                }
            }
            return doubleValue;
        }
    }
}
