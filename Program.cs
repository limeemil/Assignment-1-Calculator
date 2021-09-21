using System;
using System.Globalization;

namespace Assignment_1__Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            string userInput;
            Console.WriteLine("Calculator");
            do
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");
                Console.WriteLine("0: Exit");
                Console.Write("What do you want to do? Enter the corresponding number: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("The sum is: " + Addition());
                        break;

                    case "2":
                        Console.WriteLine("The difference is: " + Subtraction());
                        break;

                    case "3":
                        Console.WriteLine("The product is: " + Multiplication());
                        break;

                    case "4":
                        Console.WriteLine("The ratio is: " + Division());
                        break;

                    case "0":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
            }
            while (isRunning);
        }

        static double GetNumberFromUser()
        {
            double number = 0;
            bool success = false;
            string input;
            
            while (!success)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();
                success = double.TryParse(input.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out number);
                if (!success)
                {
                    Console.WriteLine("Invalid input, please write a number.");
                }
            }
            return number;
        }

        static double Addition()
        {
            double term1, term2;
            Console.WriteLine("Add two numbers together");
            term1 = GetNumberFromUser();
            term2 = GetNumberFromUser();
            return term1 + term2;

        }

        static double Subtraction()
        {
            double term1, term2;
            Console.WriteLine("Subtract two numbers");
            term1 = GetNumberFromUser();
            term2 = GetNumberFromUser();
            return term1 - term2;
        }

        static double Multiplication()
        {
            double factor1, factor2;
            Console.WriteLine("Multiply two numbers");
            factor1 = GetNumberFromUser();
            factor2 = GetNumberFromUser();
            return factor1 * factor2;
        }

        static double Division()
        {
            double num, den;
            Console.WriteLine("Divide two numbers");
            num = GetNumberFromUser();
            do
            {
                den = GetNumberFromUser();
                if (den == 0)
                {
                    Console.WriteLine("Denominator can not be 0, please try again.");
                }
            }
            while (den == 0);

            return num / den;
        }
    }
}
