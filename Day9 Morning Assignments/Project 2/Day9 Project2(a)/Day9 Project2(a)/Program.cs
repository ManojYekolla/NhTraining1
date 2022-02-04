using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Project2_a_
{
    class MathTask
    {
        private int a;
        private int b;

       
        public void ReadInput()
        {
            Console.WriteLine("Enter a first number :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number :");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public int PrintInput()
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathTask obj=new MathTask();
            obj.ReadInput();
            Console.WriteLine(obj.PrintInput());
            Console.ReadLine();
        }
    }
}
