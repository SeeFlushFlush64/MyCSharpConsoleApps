using System;

namespace BasicCalculator
{
    class Program
    {
        static void OpeningPrompt()
        {
            Console.WriteLine("Welcome to my Basic Calculator");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

        static int GetValidNumber(string prompt)
        {
            int number;
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.WriteLine();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    Console.WriteLine();
                }
            }
            return number;
        }

        static void PerformCalculation(int firstNum, int secondNum)
        {
            Console.WriteLine();
            Console.WriteLine("List of Mathematical Operations");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("(+) Addition\t(-) Subtraction\t\t(*) Multiplication\t(/) Division");
            Console.WriteLine();
            string operation;
            int result = 0;

            while (true)
            {
                Console.Write("Which operation should we use: ");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = firstNum + secondNum;
                        break;
                    case "-":
                        result = firstNum - secondNum;
                        break;
                    case "*":
                        result = firstNum * secondNum;
                        break;
                    case "/":
                        result = firstNum / secondNum;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid operation.");
                        Console.WriteLine();
                        continue;
                }
                break;
            }
            Console.WriteLine($"The calculated result: {result}");
        }

        static void Main(string[] args)
        {
            OpeningPrompt();
            int firstNum = GetValidNumber("Please enter the first number: ");
            int secondNum = GetValidNumber("Please enter the second number: ");
            PerformCalculation(firstNum, secondNum);
        }
    }
}
