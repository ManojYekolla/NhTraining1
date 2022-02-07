using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Project1_b_
{
    interface Ishape
    {
        int CalPerimeter();
        int CalArea();
    }
    class square : Ishape
    {
        private int side;

        public void ReadSide()
        {
            Console.WriteLine("Enter a Square Side :");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int CalArea()
        {
            return side * side;
        }

        public int CalPerimeter()
        {
            return 4 * side;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            square obj =new square();
            obj.ReadSide();
            Console.WriteLine("square Area value is :{0}",obj.CalArea());
            Console.WriteLine("square Perimeter value is :{0}",obj.CalPerimeter());

            Console.ReadLine();
        }
    }
}
