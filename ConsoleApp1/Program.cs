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
            Value();
        }
        public static void Value()
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            double result = Function(a);
            Console.WriteLine($"b={result}");
            Console.Read();
        }
        public static double Function(double a)
        {
            return 12 * Math.Pow(a, 2) + 7 * a - 6;
        }
    }
}
