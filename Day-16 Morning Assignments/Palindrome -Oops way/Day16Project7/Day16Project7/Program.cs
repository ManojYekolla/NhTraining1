using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project7
{
    class Program1
    {
        private int n;

        public void ReadData()
        {
            Console.WriteLine("Enter a Number is :");
            n=Convert.ToInt32(Console.ReadLine());
        }
        public void PrintData()
        {
            int r, sum = 0, temp;
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Program1 obj = new Program1();
            obj.ReadData();
            obj.PrintData();
            Console.ReadLine();
        }
    }
}
