using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(55);
            data.Push(28);
            data.Push(68);

            Console.WriteLine(data.Count);
            Console.WriteLine(data.Pop());   //it will remove the element(pop)
           // Console.WriteLine(data.Peek());  //it will not remove the element(peek)
            Console.WriteLine(data.Count);
            Console.ReadLine();

        }
    }
}
