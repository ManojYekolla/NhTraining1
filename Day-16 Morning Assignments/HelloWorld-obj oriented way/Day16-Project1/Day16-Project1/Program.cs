using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Project1
{
    class Hello
    {
        public static void Manoj()
        {
            Console.WriteLine("Hello World");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Hello obj = new Hello();
                Hello.Manoj();
               
                Console.ReadLine();

            }
        }
    }
}
