using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_problem_Reasearch
{
    interface IRules
    {
        int Age { get; set; }

        int add(int a, int b);

        public void PrintHi()
        {
            Console.WriteLine("Hi");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
