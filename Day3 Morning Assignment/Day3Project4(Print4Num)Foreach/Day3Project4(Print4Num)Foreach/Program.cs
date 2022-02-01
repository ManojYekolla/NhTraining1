﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Project4_Print4Num_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Declaration Section
            int[] data = new int[4];
            Console.WriteLine("\n**************** Please Provide 4 Numbers to store in an Array and Retrive at the END ****************\n");
            //Reading Array data from the user
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter {i + 1} number :");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Printing Array Values from the data[] using foreach loop
            Console.WriteLine("\n::: The User Entered Values To store in an Array Are... :::");
            foreach (int d in data)
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }
    }
}
