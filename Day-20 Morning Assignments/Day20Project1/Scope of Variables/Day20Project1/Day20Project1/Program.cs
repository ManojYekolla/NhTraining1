using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project1
{
    class ClassScope
    {

        // class level variable
        string str = "Manoj Yekolla-ClassLevel Scope";

        public void display()
        {
            Console.WriteLine(str);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassScope obj=new ClassScope();
            obj.display();
            Console.ReadLine();
        }
    }
}

