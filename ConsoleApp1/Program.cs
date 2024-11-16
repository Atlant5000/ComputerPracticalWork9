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
            Console.Write("x1=");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1=");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("x2=");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2=");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("x3=");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3=");
            double y3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Perimeter={D(F(x1, y1, x2, y2), F(x2, y2, x3, y3), F(x3, y3, x1, y1))}");
            Console.Read();
        }
        public static double F(double x1 ,double y1 ,double x2 ,double y2)
        {
            return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1,2));
        }
        public static double D(double a, double b, double c)
        {
            return Math.Round(a + b + c,1);
        }
    }
}
