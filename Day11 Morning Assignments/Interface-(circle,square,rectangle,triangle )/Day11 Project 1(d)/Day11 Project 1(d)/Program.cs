using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Project_1_d_
{
    interface Ishape
    {
        int CalPerimeter();
        int CalArea();
    }

    class Triangle : Ishape
    {
        private int side1;
        private int side2;
        private int side3;

        public void ReadTriangle()
        {
            Console.WriteLine("Enter a Side 1 triangle value :");
            side1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Side 2 triangle value :");
            side2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Side 3 triangle value :");
            side3 = Convert.ToInt32(Console.ReadLine());

        }
        public int CalArea()
        {
            double semiperimeter = (side1 + side2 + side3) / 2;
            double Area = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
            return Convert.ToInt32( Area);
        }

        public int CalPerimeter()
        {
            return side1 + side2 + side3;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle();
            tri.ReadTriangle();
            Console.WriteLine("Enter triangle Perimeter Value is :{0}",tri.CalPerimeter());
            Console.WriteLine("Enter triangle Area Value is :{0}",tri.CalArea());

            Console.ReadLine();
        }
    }
}
