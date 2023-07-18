using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Header();
            MainMenu();
        }

        public static void Header()
        {
            Console.WriteLine("##### Calculator #####");
        }

        public static void MainMenu()
        {
            int choice = 0;

            Console.WriteLine("Enter the option: ");
            while (choice != 4)

            {
                Console.WriteLine("To use the calculator function type 1: ");
                Console.WriteLine("To use the Fibonacci function type 2: ");
                Console.WriteLine("To calculate the root type 3: ");
                Console.WriteLine("To exit type 4: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    OperationsMenu();
                }
                if (choice == 2)
                {
                    Fibonacci();
                }

                Console.ReadLine();
            }
        }

        public static void OperationsMenu()
        {
            double value1, value2;
            string operation;

            try
            {
                Console.WriteLine("Enter the first value: ");
                if (!double.TryParse(Console.ReadLine(), out value1))
                {
                    Console.WriteLine("Invalid Number! Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                }

                Console.WriteLine("Enter the operation: ");
                operation = Console.ReadLine();
                if (operation.Length != 1 || !Regex.IsMatch(operation, "^([-+\\/*%])", RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Invalid operator! Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                }

                Console.WriteLine("Enter the second value: ");
                if (!double.TryParse(Console.ReadLine(), out value2))
                {
                    Console.WriteLine("Invalid Number! Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu();
                }

                Console.WriteLine("");

                switch (operation)
                {
                    case "+":
                        Sum(value1, value2);
                        break;

                    case "-":
                        Subtraction(value1, value2);
                        break;

                    case "*":
                        Multiplication(value1, value2);
                        break;

                    case "/":
                        Divide(value1, value2);
                        break;

                    case "%":
                        Modulo(value1, value2);
                        break;

                    default:
                        Console.WriteLine("Non-existent option!");
                        Console.ReadKey();
                        MainMenu();
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        static void Sum(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine($"The sum result of {num1} + {num2}, it's the same as {result}");
            Console.ReadKey();
            MainMenu();
        }
        static void Subtraction(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine($"The subtraction result of {num1} - {num2}, it's the same as {result}");
            Console.ReadKey();
            MainMenu();
        }
        static void Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine($"The multiplication result of {num1} * {num2}, it's the same as {result}");
            Console.ReadKey();
            MainMenu();
        }
        static void Divide(double num1, double num2)
        {

            try
            {
                if (num2 == 0)
                    throw new DivideByZeroException();
                double result = num1 / num2;
                Console.WriteLine($"The divide result of {num1} / {num2}, it's the same as {result}");
                Console.ReadKey();
                MainMenu();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Division of {0} by zero.", num2);
                MainMenu();
            }
        }
        static void Modulo(double num1, double num2)
        {
            double result = num1 % num2;
            Console.WriteLine($"The modulo result of {num1} % {num2}, it's the same as {result}");
            Console.ReadKey();
            MainMenu();
        }
        static void Fibonacci()
        {
            int num1 = 0;
            int num2 = 1;
            int fibonacci;
            int number;
            string result = $"{num1} - {num2}";

            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            if (number < 1)
            {
                Console.WriteLine("Invalid Number! Press any key to continue");
            }
            else
            {
                for (int i = 0; i < number - 2; i++)
                {

                    fibonacci = num1 + num2;
                    result += $" - {fibonacci}";
                    num1 = num2;
                    num2 = fibonacci;

                }
                Console.WriteLine(result);
                Console.ReadKey();
                MainMenu();
            }
        }
    }
}
