using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLevelScope
{
    class MethodLevel
    {
        public void method1()
        {
            //display variable inside method
            string str = "method level";
        }
        public void method2()
        {
            //accessing str from method2()  //Error Code
            Console.WriteLine(str);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MethodLevel obj = new MethodLevel();
            obj.method1();
            Console.ReadLine();
            

           }
    }
}
