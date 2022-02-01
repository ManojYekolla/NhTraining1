using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project_8_a_
{
    class Customer
    {
        public int id;
        public string name;
        public long mobile;
        public string email;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] cust = new Customer[]
            {
                new Customer(){id=1,name="manojyek",mobile=9010203045,email="manoj@gmail.com"},
                new Customer(){id=2,name="murali",mobile=8994939923,email="murali33@gmail.com"},
                new Customer(){id=3,name="dhawan",mobile=7899938545,email="dhawan@gmail.com"},
                new Customer(){id=4,name="nithesh",mobile=9049599599,email="nith@gmail.com"},

            };
            //for loop
            for (int i = 0; i < cust.Length; i++)
            {
                Console.WriteLine($"id={cust[i].id},name={cust[i].name},mobile={cust[i].mobile},email={cust[i].email}");

            }
            //forEach
            foreach (var e in cust)
            {
                Console.WriteLine($"id={e.id},name={e.name},mobile={e.mobile},email={e.email}");
            }

            //lamda experssion
            cust.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},mobile={e.mobile},email={e.email}"));

            Console.ReadLine();
        }
    }
}
