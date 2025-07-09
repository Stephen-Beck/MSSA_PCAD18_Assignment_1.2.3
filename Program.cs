/*
Write a menu driven application to perform calculation functions like addition, subtraction, multiplication, and division. 
Call them appropriately when user selects the option.
Give the user the option to continue or exit the program.
 */

namespace Assignment_1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                double answer = 0;
                bool validOperator = true;
                string operatorInput;


                Console.Clear();
                Console.WriteLine("Welcome to this console-based calculator!");

                Console.Write("Input your first number: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());

                do
                {
                    Console.Write("\nInput your operator (+, -, *, /): ");
                    operatorInput = Console.ReadLine();

                    switch (operatorInput)
                    {
                        case "+":
                        case "-":
                        case "*":
                        case "/":
                            validOperator = true;
                            break;
                        default:
                            Console.WriteLine("Invalid operator. Please use +, -, *, or /");
                            validOperator = false;
                            break;
                    }
                } while (!validOperator);

                Console.Write("\nInput your second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                switch (operatorInput)
                {
                    case "+":
                        answer = firstNumber + secondNumber;
                        break;
                    case "-":
                        answer = firstNumber - secondNumber;
                        break;
                    case "*":
                        answer = firstNumber * secondNumber;
                        break;
                    case "/":
                        answer = firstNumber / secondNumber;
                        break;
                }

                if (operatorInput == "/" && secondNumber == 0)
                {
                    Console.WriteLine(firstNumber + " " + operatorInput + " " + secondNumber + " = undefined");
                    Console.WriteLine("The answer is undefined. You cannot divide by zero!");
                }
                else
                {
                    Console.WriteLine(firstNumber + " " + operatorInput + " " + secondNumber + " = " + answer);
                    Console.WriteLine("The answer is: " + answer);
                }

                Console.WriteLine("\n    Would you like to do another calculation?");
                Console.WriteLine("(Press 'N' to exit or any other key to continue.)");
                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    exit = true;
                    Console.Clear();
                    Console.WriteLine("Exiting...");
                }
            }
        }
    }
}
