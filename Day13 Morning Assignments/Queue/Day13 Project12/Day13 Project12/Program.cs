using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Project11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(55);
            data.Enqueue(28);
            data.Enqueue(68);

            Console.WriteLine(data.Count);
            Console.WriteLine(data.Dequeue());   
            Console.WriteLine(data.Count);
            Console.ReadLine();

        }
    }
}
