using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("F:\\Nb\\Mydata\\HelloManoj Y.txt","How are You");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
