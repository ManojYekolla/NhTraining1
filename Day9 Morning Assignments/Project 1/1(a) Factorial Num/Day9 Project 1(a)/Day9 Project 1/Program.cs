using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Project_1_a_
{
    class MathsOperation
    {
        private int input;

        public void ReadInput()
        {
            Console.WriteLine("Enter a Factorial Number :");
            input = Convert.ToInt32(Console.ReadLine());
        }

        public int Factorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact = fact * i;

            }
            return fact;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsOperation mo = new MathsOperation();
            mo.ReadInput();
            mo.Factorial();

            Console.WriteLine(mo.Factorial());
            Console.ReadLine();
        }
    }
}
