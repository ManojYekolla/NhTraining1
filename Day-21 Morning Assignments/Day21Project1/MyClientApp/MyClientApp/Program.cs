using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClientApp.ServiceReference1;

namespace MyClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlgebraSoapClient obj = new AlgebraSoapClient();

            Console.WriteLine("Factorial Number 5 is {0}:",obj.Factorial(5));
            Console.WriteLine("Add two Numbers 5 and 4 is {0}:", obj.Add(5,4));
            Console.WriteLine("Mul two Numbers 8 and 3is {0}:", obj.Mul(8,3));
            Console.WriteLine("Div two Numbers 6 and 4 is {0}:", obj.Div(6,4));

            Console.ReadLine();
        }
    }
}
    

