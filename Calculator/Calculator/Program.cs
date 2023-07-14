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
            Menu();
        }

        public static void Header()
        {
            Console.WriteLine("##### Calculator #####");
        }

        public static void Menu()
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
                    Menu();
                }
                Console.WriteLine("Enter the operation: ");
                operation = Console.ReadLine();
                if (operation.Length != 1 || !Regex.IsMatch(operation, "^([-+\\/*%])", RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Invalid operator! Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Menu();
                }


                Console.WriteLine("Enter the second value: ");
                if (!double.TryParse(Console.ReadLine(), out value2))
                {
                    Console.WriteLine("Invalid Number! Press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Menu();
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
                        Menu();
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
            Menu();
        }
        static void Subtraction(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine($"The subtraction result of {num1} - {num2}, it's the same as {result}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine($"The multiplication result of {num1} * {num2}, it's the same as {result}");
            Console.ReadKey();
            Menu();
        }
        static void Divide(double num1, double num2)
        {
            double result = num1 / num2;
            Console.WriteLine($"The divide result of {num1} / {num2}, it's the same as {result}");
            Console.ReadKey();
            Menu();
        }
        static void Modulo(double num1, double num2)
        {
            double result = num1 % num2;
            Console.WriteLine($"The modulo result of {num1} % {num2}, it's the same as {result}");
            Console.ReadKey();
            Menu();
        }
    }
}
