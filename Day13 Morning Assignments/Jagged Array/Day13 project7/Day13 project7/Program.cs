using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[3][];
            names[0] = new char[] { 'm', 'a', 'n', 'u' };
            names[1] = new char[] { 'n', 'i', 't', 'h', 'e', 's', 'h' };
            names[2] = new char[] { 'r', 'a', 'v', 'i' };

            for (int i=0;i<3;i++)
            {
                for (int j=0;j<names[i].Length;j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
