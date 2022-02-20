using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes_Pgm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ? input = 4;
            if (input.HasValue)
           
                Console.WriteLine(input*input);
            
            else
                 Console.WriteLine("Novalues found");

            Console.ReadLine();
        }
    }
}
