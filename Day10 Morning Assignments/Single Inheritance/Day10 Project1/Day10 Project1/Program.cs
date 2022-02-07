using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Project1
{
    class Algebra
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }

        class Math : Algebra
        {
            public int Mul(int a, int b)
            {
                return a * b;
            }
        }
    
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Math obj= new Math();
            Console.WriteLine("\nsum 11 and 2 is {0}" ,obj.Add(11,2));
            Console.WriteLine("\nsub 11 and 2 is {0}", obj.Sub(11, 2));
            Console.WriteLine("\nmul 11 and 2 is {0}", obj.Mul(11, 2));
            Console.ReadLine();
            

        }
    }
}
