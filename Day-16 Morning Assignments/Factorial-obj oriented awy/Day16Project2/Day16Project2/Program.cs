using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project2
{
    class Math
    {
        private int Input;
        
        public void ReadData()
        {
            Console.WriteLine("Enter a Factorial Number is :");
            Input =Convert.ToInt32( Console.ReadLine());
        }
        public int PrintData()
        {
            int fact = 1;
            for (int i=1;i<=Input;i++)
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
            Math obj = new Math();
            obj.ReadData();
            Console.WriteLine("Print factorial is :{0}",obj.PrintData());
            Console.ReadLine();
        }
    }
}
