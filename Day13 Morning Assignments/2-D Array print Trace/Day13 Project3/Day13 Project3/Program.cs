using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 3, 2, 3, }, { 5, 3, 4, }, { 2, 4,6 } };
            int sum = 0;
            for (int i=0;i<3;i++)
            {
                for (int j=0;j<3;j++)
                {
                    if (i == j)
                        sum = sum + data[i, j];

                }
            }
            Console.WriteLine("Enter the Sum Value in Trace is :{0}",sum);
            Console.ReadLine();
        }
    }
}
