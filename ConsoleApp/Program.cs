using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор. Доступные операции: +, -, *, /");
            while (true)
            {
                Console.Write("Введите операцию (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("\nВведите первое число: ");
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("Ошибка: некорректный ввод первого числа!");
                    continue;
                }

                Console.Write("Введите второе число: ");
                if (!double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.WriteLine("Ошибка: некорректный ввод второго числа!");
                    continue;
                }

                double result = 0;
                bool operationValid = true;

                switch (op)
                {
                    case "+":
                        result = Calculator.Sum(a, b);
                        break;
                    case "-":
                        result = Calculator.Subtract(a, b); // Исправлено имя метода
                        break;
                    case "*":
                        result = Calculator.Multiply(a, b);
                        break;
                    case "/":
                        if (b != 0)
                            result = Calculator.Divide(a, b);
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль!");
                            operationValid = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция!");
                        operationValid = false;
                        continue;
                }

                if (operationValid)
                    Console.WriteLine($"Результат: {result}");
            }
        }
    }

    // Класс Calculator с необходимыми методами
    internal static class Calculator
    {
        public static double Sum(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b) => a / b;
    }
}

