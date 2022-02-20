using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockLevelScope
{
    class BlockLevel
    {
        public void display()
        {

            for (int i = 0; i <= 3; i++)
            {

            }
            Console.WriteLine(i);
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            BlockLevel level = new BlockLevel();
            level.display();
            Console.ReadLine();
        }
    }
}
