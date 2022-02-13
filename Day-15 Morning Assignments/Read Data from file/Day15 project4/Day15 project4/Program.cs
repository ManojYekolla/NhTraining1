using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("F:\\Nb\\Mydata\\ReadData.txt");
            string data = sr.ReadLine();
            while(data != null)
            {
                Console.WriteLine(  data);
                data = sr.ReadLine();
            }
            Console.WriteLine("File Reading Done");
            Console.ReadLine();

        }
    }
}
