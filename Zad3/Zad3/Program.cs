using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Начало на интервала: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Край на интервала: ");
            int end = int.Parse(Console.ReadLine());

            if (start % 2 != 0) start += 1;

            for(int i = start; i <= end; i+=2) Console.WriteLine(i); 
        }
    }
}
