using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4_List_int_Find_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum = 0;
            data.Add(10);
            data.Add(19);
            data.Add(53);
            data.Add(49);
            foreach(var d in data)
            {
                sum = sum + d;
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
