using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c;
            Console.WriteLine("enter a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b");
            b = int.Parse(Console.ReadLine());
            c = multiply(a, b);
            add(a, b);

            Console.WriteLine("product of {0} and {1}={2}", a, b, c);
        }
        public static double multiply(int a, int b)
        {
            double prod = a * b;
            return prod;
        }
         
        static void add(int a,int b)
        {
            int d = a + b;
            Console.WriteLine("addition of two numbers" + d);
        }

      
        
    }
}
