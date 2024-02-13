using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значения параметра x = ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);

            double F = 4 * Math.Sin(x) * 5 * Math.Cos(x);

            Console.WriteLine($"Для значения х = {x}, F = {F}");
        }
    }
}
