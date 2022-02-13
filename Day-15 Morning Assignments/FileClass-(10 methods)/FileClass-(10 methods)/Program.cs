using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileClass__10_methods_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Create("F:\\Nb\\Mydata\\HelloManoj Y.txt");
            Console.WriteLine("file created");
            Console.ReadLine();
        }
    }
}
