using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Project1_b_
{
    class MathOperation
    {
        private int input;

        //Read Factors
        public void ReadFactors()
        {
            Console.WriteLine("Enter a Number :");
            input = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintFactors()
        {
            for (int i=1;i<=input;i++)
            {
                if (input % i == 0)
                    Console.WriteLine(i);
            }
           
               
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation obj = new MathOperation();
            {
                obj.ReadFactors();
                obj.PrintFactors();
              
                Console.ReadLine();
            }
        }
    }
}
