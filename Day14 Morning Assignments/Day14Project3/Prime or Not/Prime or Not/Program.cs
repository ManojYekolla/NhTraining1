using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n=11;
            for (i = 2; i<=n; i++)
            {
                if (n % i == 0)
                    break;
            }
            if(i==n)
                Console.WriteLine("prime");
            else
                Console.WriteLine("not prime");
            Console.ReadLine();
        }
    }
}
