using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Project5
{
    class English
    {
        public void Hi()
        {
            Console.WriteLine("Hi");
        }
        public void Hlo()
        {
            Console.WriteLine("Hlo");
        }
        public virtual void Gm()
        {
            Console.WriteLine("Gm");
        }
    }

    class Telugu : English
    {
        public override void Gm()
        {
            Console.WriteLine("Subhodhyam");
        }
    }
    internal class Program 
    {
        static void Main(string[] args)
        {
            Telugu obj = new Telugu();
            obj.Hi();
            obj.Hlo();
            obj.Gm();
            
            Console.ReadLine();

        }
    }
}
