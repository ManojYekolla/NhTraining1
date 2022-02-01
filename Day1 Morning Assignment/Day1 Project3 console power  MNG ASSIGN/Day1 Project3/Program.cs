using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, sum = 0;
            int p = 1;
            Console.WriteLine("Enter the first number:");
            fn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            sn = Convert.ToInt32(Console.ReadLine());

            for (int i = 1;i <=sn;i++)
                p = p * fn;

            Console.WriteLine("Power=" + p);
            Console.ReadLine();
        }
    }
}
