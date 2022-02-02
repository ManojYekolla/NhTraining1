using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Project5
{
    class Order
    {
        public int id;
        public string custname;
        public int OrderPrice;
        public string CustAddress;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> order = new List<Order>()
            {
                new Order() {id=1,custname="manojy",OrderPrice=500},
                new Order() {id=2,custname="murali",OrderPrice=800},
                new Order() {id=3,custname="krish",OrderPrice=1500},
                new Order() {id=4,custname="suresh",OrderPrice=250},
            };

            //using for loop
            for (int i=0;i<order.Count;i++)
            {
                Console.WriteLine($"id={order[i].id},custname={order[i].custname},orderprice={order[i].OrderPrice}");
            }

            //using foreach loop
            foreach(var o in order)
            {
                Console.WriteLine($"id={o.id},custname={o.custname},orderprice={o.OrderPrice}");
            }

            //using lamda
            order.ToList().ForEach(o => Console.WriteLine($"id={o.id},custname={o.custname},orderprice={o.OrderPrice}"));

            //using linq
            var result = from o in order
                         select o;
            result.ToList().ForEach(o => Console.WriteLine($"id={o.id},custname={o.custname},orderprice={o.OrderPrice}"));
            Console.ReadLine();
        }
    }
}
