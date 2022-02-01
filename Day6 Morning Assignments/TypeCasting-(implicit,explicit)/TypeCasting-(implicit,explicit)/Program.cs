using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting__implicit_explicit_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);
            Console.ReadLine();
        }
    }
}
