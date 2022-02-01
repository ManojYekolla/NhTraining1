using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Project8_b_
{
    class Product
    {
        public int id;
        public string name;
        public double price;
        public string colour;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] prod = new Product[]
            {
                new Product(){id=1,name="manojyek",price=10000,colour="red"},
                new Product(){id=2,name="murali",price=20000,colour="blue"},
                new Product(){id=3,name="dhawan",price=30000,colour="green"},
                new Product(){id=4,name="nithesh",price=40000,colour="yellow"},

            };
            //for loop
            for (int i = 0; i < prod.Length; i++)
            {
                Console.WriteLine($"id={prod[i].id},name={prod[i].name},price={prod[i].price},colour={prod[i].colour}");

            }
            //forEach
            foreach (var e in prod)
            {
                Console.WriteLine($"id={e.id},name={e.name},price={e.price},colour={e.colour}");
            }

            //lamda experssion
            prod.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},price={e.price},colour={e.colour}"));

            Console.ReadLine();
        }
    }
}
