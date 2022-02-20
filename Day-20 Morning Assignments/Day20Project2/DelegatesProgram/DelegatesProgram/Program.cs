using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProgram
{
    public delegate void Manoj(int a, int b);
    internal class Program
    {
        public static void Add(int a ,int b)
        {
            Console.WriteLine(a+b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {
            Manoj obj = new Manoj(Add);
            obj += Mul;
            obj += Div;

            //12,13
            obj(12, 13);
            Console.WriteLine("-----------------------------------------");

            //44,6
            obj -= Add;
            obj(44, 6);
            Console.ReadLine();


        }
    }
}
