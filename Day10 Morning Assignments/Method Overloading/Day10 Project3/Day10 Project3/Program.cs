using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Project3
{
    class Mathematics
    {
        public int Add(int a , int b)
        {
            return a + b;
        }
        public int Add(int a, int b,int c)
        {
            return a + b+c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics obj = new Mathematics();
             Console.WriteLine(" Add of Two Numbers 8 and 10 is : {0}", obj.Add(8, 10));
            Console.WriteLine(" Add of Three Numbers 8 ,12and 10 is : {0} ", obj.Add(8,12, 10));
            //Console.WriteLine(obj.Add(2, 8));
            Console.ReadLine();
        }
    }
}
