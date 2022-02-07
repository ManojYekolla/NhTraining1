using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Project1
{
    interface Ishape
    {
        int CalculatePerimeter();
        int CalculateArea();
    }

    class circle : Ishape
    {
        private int radius;

        // Read Radius
        public void ReadRadius()
        {
            Console.WriteLine("Enter a radius :");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return 22 * radius * radius / 7;
        }

        public int CalculatePerimeter()
        {
            return 2* 22 * radius / 7;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            c.ReadRadius();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Enter circle perimeter is :{0}",c.CalculatePerimeter());
            Console.WriteLine("Enter a circle Area is :{0}",c.CalculateArea());

            Console.ReadLine();
            
        }
    }
}
