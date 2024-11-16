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
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int result1 = Sum(a, b);
            Console.WriteLine($"Sum={result1}");
            int result2 = Difference(a, b);
            Console.WriteLine($"Difference={result2}");
            int result3 = Product(a, b);
            Console.WriteLine($"Product={result3}");
            double result4 = Quotient(a, b);
            Console.WriteLine($"Quotient={result4}");
            Console.Read();
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Difference(int a, int b)
        {
            return a - b;
        }
        public static int Product(int a,int b)
        {
            return a * b;
        }
        public static double Quotient(double a,double b)
        {
            return a / b;
        }
    }
}
