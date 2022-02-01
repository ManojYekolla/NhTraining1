using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project4
{
    class Customer
    {
        private string name;
        private string email;
        private long mobile;
        private string address;

        public void ReadCustomer()
        {
            Console.WriteLine("Enter your Name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your Email :");
            email = Console.ReadLine();

            Console.WriteLine("Enter Your Mobile Number :");
            mobile = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Address :");
             address = Console.ReadLine();
        }
        public void PrintCustomer()
        {
            Console.WriteLine($"Name={name},Email={email},Mobile={mobile},Address={address}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.ReadCustomer();
            cust.PrintCustomer();
            Console.ReadLine();
        }
    }
}
