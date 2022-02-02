using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 12, 45, 98, 33, 67, 28, 47, 22 };

            //Even Numbers using For Loop
            for (int i=0;i<data.Count;i++)
            {
                if (data[i] %2 == 0) 
                Console.WriteLine(data[i]);
                
            }

            // using for each loop

            foreach(var d in data)
            {
                if(d%2==0)
                    Console.WriteLine(d);
            }

            //using lamda expression
            data.Where(d => d % 2 == 0).ToList().ForEach(d => Console.WriteLine(d));

            //using linq 
            var result = from d in data
                         where d % 2 == 0
                         select d;

            result.ToList().ForEach(e => Console.WriteLine(e));
            Console.ReadLine();
        }
    }
}
