using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Project4
{
    class EnglishMsg
    {
        public void PrintHi()
        {
            Console.WriteLine("Hi");
        }
        public void PrintHlo()
        {
            Console.WriteLine("Hlo");
        }
        public void PrintGm()
        {
            Console.WriteLine("Gm");
        }
    }

    class TeluguMsg :EnglishMsg
    {
        public new void PrintGm()
        {
            Console.WriteLine("subhodhyam");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TeluguMsg obj = new TeluguMsg();
            obj.PrintHi();
            obj.PrintHlo();
            obj.PrintGm();
            
            Console.ReadLine();
        }
    }
}
