using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_project3
{
    class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;  

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() {id=1,name="Gabbar",price=6000,brand="moto mobile"},
                new Product() {id=2,name="Manoj",price=10000,brand="Realme mobile"},
                new Product() {id=3,name="Chandhra",price=12000,brand="MI mobile"},
                new Product() {id=4,name="Jeevan",price=8000,brand="samsung mobile"},

            };
            // for loop
            for(int i = 0; i < products.Count; i++)
            {
                if(products[i].price>8000)
                    Console.WriteLine($"name={products[i].name},brand={products[i].brand}");
            }

            //using foreach
            foreach(var p in products)
            {
                if (p.price > 8000) 
                Console.WriteLine($"name={p.name},brand={p.brand}");
            }

            //lamda 
            products.ToList().Where(p => p.price > 8000).ToList().ForEach(p => Console.WriteLine($"name={p.name},brand={p.brand}"));

            //linq

            var result = from p in products
                         where p.price > 8000
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"name={p.name},brand={p.brand}"));
            Console.ReadLine();


        }
    }
}
