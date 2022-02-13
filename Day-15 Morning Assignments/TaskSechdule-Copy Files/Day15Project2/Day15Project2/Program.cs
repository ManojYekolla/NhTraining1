using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("F:\\Nb\\Mydata\\HelloManoj Y.txt", "F:\\Nb\\My Server");
            Console.WriteLine("File Copied");
            Console.ReadLine();
        }
    }
}
