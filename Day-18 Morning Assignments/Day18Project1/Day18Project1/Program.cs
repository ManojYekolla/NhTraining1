using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManojLibrary1;

namespace Day18Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a Number is :");
            n=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial.Algebra(n));
            Console.ReadLine();
        }
    }
}
