using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project_6
{
    class Mathmetics
    {
        private int Input;
        private int i;

        public void ReadData()
        {
            Console.WriteLine("Enter any Number");
            Input=Convert.ToInt32(Console.ReadLine());       
        }
        public  void PrintData()
        {
            for (i = 1; i <= 10; i++)
            {
                //Printing OutPut using String Formating
                Console.WriteLine("{0} x {1} = {2}", Input, i, Input * i);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathmetics obj=new Mathmetics();
            
            obj.ReadData();
            Console.WriteLine("------------");
            obj.PrintData();
            Console.ReadLine();
        }
    }
}
