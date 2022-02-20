using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameter
{
    
 internal class Program 
    {
        public static string Ref(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 5;
            return returnText;
        }
        
        public static string Out(out int id)
        {
            id = 5;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }
       


        static void Main(string[] args)
        {
            Console.WriteLine("\n -----------Ref-----------");
            int i = 5;
            Console.WriteLine("previous value i is : " + i.ToString());
            string testRef = Ref(ref i);
            Console.WriteLine("current value i is : " + i.ToString());
            Console.WriteLine("\n -----------Out-----------");
            int j;
            string testOut = Out(out j);
            Console.WriteLine("Current value of  j:" + j.ToString());
            Console.ReadLine();

        }
    }
}

