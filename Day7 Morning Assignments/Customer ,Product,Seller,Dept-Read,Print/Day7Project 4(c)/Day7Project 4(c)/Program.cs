using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project_4_c_
{
    class Seller
    {
        private int id;
        private string name;
        private long mobile;
        private string address;

        public void ReadSeller()
        {
            Console.WriteLine("Enter Your seller Id : ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your Seller name : ");
            name = Console.ReadLine();

            Console.WriteLine("enter your seller mobile  :");
            mobile = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your  Seller Address :");
            address = Console.ReadLine();
        }
        public void PrintProduct()
        {
            Console.WriteLine($"id={id},name={name},mobile={mobile},address={address}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Seller sell=new Seller();
            sell.ReadSeller();
            sell.PrintProduct();
            Console.ReadLine();
        }
    }
}
