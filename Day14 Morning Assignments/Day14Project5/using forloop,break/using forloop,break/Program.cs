using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace using_forloop_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1000; i<=1097; i++)
            {
                if (i % 97 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
                
            }
            Console.ReadLine();
        }
    }
}
