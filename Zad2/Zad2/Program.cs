using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете 1-вото число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Въведете 2-рото число: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Въведете операцията: ");
            char operation = char.Parse(Console.ReadLine());
            double result;

            switch (operation)
            {
                case '+':
                    result = a + b;
                    break;

                case '-':
                    result = a - b;
                    break;

                case '*':
                    result = a * b;
                    break;

                case '/':
                    result = a / b;
                    break;

                default:
                    Console.WriteLine("Грешно въведена операция:");
                    result = 0;
                    break;
            }
            Console.WriteLine($"Резултатът е {result}");
        }
    }
}
