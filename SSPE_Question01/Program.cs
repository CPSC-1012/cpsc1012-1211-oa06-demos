using System;

namespace SSPE_Question01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for the name, age, and annualPay
            string name;// = "Rachel Notely";
            int age;// = 53;
            double annualPay;// = 133404.00;

            // Prompt and read in the name
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            // Prompt and read in the age
            Console.Write("Enter your age: ");
            //string userInput = Console.ReadLine();
            //age = int.Parse(userInput);
            age = int.Parse(Console.ReadLine());

            // Prompt and read in the annualPay
            Console.Write("Ener your annual salary: ");
            annualPay = double.Parse(Console.ReadLine());

            //Console.WriteLine("My name is Don Iveson, my age is 45 and I hope to earn $204,747.00 per year.");

            // Display the results
            Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year.");
        }
    }
}
