using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_String__for_foreach_lamda_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("Manoj Y");
            data.Add("Gabbar");
            data.Add("Murali");
            data.Add("Nithesh");

            //print values using for loop

            for (int i=0;i<data.Count;i++)
            {
                Console.WriteLine(data[i]);
            }

            //print values using foreach loop
            foreach (var d in data)
            {
                Console.WriteLine(d);
            }

            //print values using lamda experssions
            data.ForEach(y=> Console.WriteLine(y));

            Console.ReadLine();
        }
    }
}
