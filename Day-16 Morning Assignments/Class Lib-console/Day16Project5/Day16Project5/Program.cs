using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManojYLibarary;

namespace Day16Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Mathmatics obj=new Mathmatics();
             obj.ReadData();
             Console.WriteLine(obj.PrintData()); */

            /* Chemistry obj=new Chemistry();
             Console.WriteLine(obj.GetBenZene());*/

            int u = 4;
            int a = 5;
            int t = 8;

            //var p=new Physics();
            //var v = p.FinalVelocity(u,a,t);


            Console.WriteLine(Physics.FinalVelocity(u,a,t));
            


            Console.ReadLine();
        }
    }
}
