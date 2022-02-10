using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
   sealed class Police
    {
        public static int code = 100;   //static variable

       /* public string GetSecret()     //method
        {
            return "003";
        }*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Police p=new Police();
            // Console.WriteLine(p.GetSecret());
            Console.WriteLine(Police.code);
            Console.ReadLine();
        }
    }
}
