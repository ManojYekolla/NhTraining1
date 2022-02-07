using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Project1_c_
{
    interface Ishape
    {
        int CalPerimeter();
        int CalArea();

    }
    class Rectangle : Ishape
    {
        private int length;
        private int width;

        public void ReadValues()
        {
            Console.WriteLine("Enter Rectangle length :");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Rectangle Width :");
            width = Convert.ToInt32(Console.ReadLine());
        }
        public int CalArea()
        {
            return length * width;  
        }

        public int CalPerimeter()
        {
            return 2*(length + width);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.ReadValues();
            Console.WriteLine("rectangle Area value is :{0}",rect.CalArea());
            Console.WriteLine("rectangle Perimeter value is :{0}",rect.CalPerimeter());

            Console.ReadLine();
        }
    }
}
