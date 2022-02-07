using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Project2
{

    class Algebra
    {
        
        public int Add(int a, int b)
        {
            return a + b;
        }
        
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
    
    class TotalMaths : Algebra
    {
        
        public int Mul(int a, int b)
        { 
            return a * b; 
        }
    }
   
    class OverAllMaths : TotalMaths
    {
        
        public int Div(int a, int b)
        {
            return a / b;
        }
        
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OverAllMaths obj = new OverAllMaths();
            
            Console.WriteLine("\n Sum of Two Numbers 8 and 9 is {0}", obj.Add(8, 9));
            Console.WriteLine("\n Difference of Two Numbers 8 and 9 is {0}", obj.Sub(8, 9));
            Console.WriteLine("\n Product of Two Numbers 8 and 9 is {0}", obj.Mul(8, 9));
            Console.WriteLine("\n Division of Two Numbers 8 and 9 is {0}", obj.Div(8, 9));
     
            Console.ReadLine();
        }
    }
}
