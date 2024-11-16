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
            Sayhello();
            Saybye();
        }
        public static void Sayhello() 
        {
            Console.WriteLine("Привет.");
        }
        public static void Saybye()
        {
            Console.WriteLine("Пока.");
            Console.Read();
        }
    }
}
