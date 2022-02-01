using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project4_b_
{
    class Product
    {
        private int id;
        private string name;
        private string description;
        private double price;

        public void ReadProduct()
        {
            Console.WriteLine("Enter Your Product Id : ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your Product name : ");
            name= Console.ReadLine();

            Console.WriteLine("enter your Product Description :");
            description= Console.ReadLine();

            Console.WriteLine("enter your Product price :");
            price= Convert.ToDouble(Console.ReadLine());
        }
        public void PrintProduct()
        {
            Console.WriteLine($"id={id},name={name},Descr={description},price={price}");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Product Pro=new Product();
            Pro.ReadProduct();
            Pro.PrintProduct();
            Console.ReadLine();
        }
    }
}
