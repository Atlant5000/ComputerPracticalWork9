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
            int result = Sum(a, b);
            Console.WriteLine($"Sum={result}");
            Console.Read();
        }
        public static int Sum(int a,int b)
        {
            return a + b;
        }
    }
}
