using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Project1_c_
{
    class MathOperation
    {
        private int input;

        public void ReadNumber()
        {
            Console.WriteLine("Enter a Number :");
            input = Convert.ToInt32(Console.ReadLine());
        }
        public bool isPrime()
        {
            int count = 0;
            for (int i=1;i<=input;i++)
            {
                
                if (input % i == 0)
                    count++;    
                 
                    
               }
            if (count == 2)
                return true;
            else
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation obj=new MathOperation();  
            obj.ReadNumber();
            if (obj.isPrime())

                Console.WriteLine("input is prime number ");
            else
                Console.WriteLine("input is not prime number");
            Console.ReadLine();
            
        }
    }
}
