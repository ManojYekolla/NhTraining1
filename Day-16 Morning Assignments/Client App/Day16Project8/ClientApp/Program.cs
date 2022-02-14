using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManojLibarary;
using PublicLibrary;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial is :{0}",Mathematics.Factorial(5));
            Console.WriteLine("\nvelocity is :{0}",Physics.Finalvelocity(3,4,5));
            Console.ReadLine();
        }
    }
}
