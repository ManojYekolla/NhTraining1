using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];
                //Read User
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter the array value ({i},{j})");
                    data[i, j] =Convert.ToInt32( Console.ReadLine());

                }
            }

            // Print User
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i,j]+ " ");

                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
