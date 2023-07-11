using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            Console.WriteLine("Enter the first value: ");
            value1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation: ");
            operation = Console.ReadLine();

            Console.WriteLine("Enter the second value: ");
            value2 = double.Parse(Console.ReadLine());

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
            Console.Clear();
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
