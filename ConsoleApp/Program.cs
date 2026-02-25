using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double b = double.Parse(Console.ReadLine());
                double result = 0;
                switch (op)
                {
                    case "+": result = Calculator.Sum(a, b); break;
                    case "-": result = Calculator.Substract(a, b); break;
                    case "*": result = Calculator.Multiply(a, b); break;
                    case "/":
                        if (b != 0) result = Calculator.Divide(a, b);
                        else Console.WriteLine("Ошибка: деление на ноль!");
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция!");
                        continue;
                }
                Console.WriteLine($"Результат: {result}");
            }
        }
    }