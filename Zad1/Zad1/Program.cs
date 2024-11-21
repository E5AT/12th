using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете радиуса(r) на окръжността");
            Console.Write("r(cm) = "); double r = double.Parse(Console.ReadLine());
            double area = Math.PI*Math.Pow(r, 2);
            Console.WriteLine($"Area = {Math.Round(area,2)} cm2");
        }
    }
}
