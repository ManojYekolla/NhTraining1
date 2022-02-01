using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Int_Find_Sum_for_foreach_lamda_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int temp;
            int sum1 = 0, sum2 = 0, sum3 = 0;
            //Read 3 Num from User

            for(int i=1;i <= 3;i++)
            {
                Console.WriteLine("enter any value :");
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }
            //find sum using for loop
            for(int i=0;i<data.Count;i++)
            
             sum1 = sum1 + data[i];

            //find sum using foreach loop
            foreach (var d in data)
                sum2 = sum2 + d;
            //find sum using lamda experssion
            data.ForEach(d => sum3 = sum3 + d);

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);



            Console.ReadLine();
        }
    }
}
