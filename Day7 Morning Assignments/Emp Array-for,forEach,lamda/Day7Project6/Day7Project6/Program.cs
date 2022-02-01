using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project6
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee(){id=1,name="manojyek",salary=5000},
                new Employee(){id=2,name="murali",salary=7000},
                new Employee(){id=3,name="dhawan",salary=15000},
                new Employee(){id=4,name="nithesh",salary=4000},

            };
            //for loop
            for (int i=0;i<employees.Length;i++)
            {
                Console.WriteLine($"id={employees[i].id},name={employees[i].name},salary={employees[i].salary}");
                
            }
            //forEach
            foreach(var e in employees)
            {
                Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}");
            }

            //lamda experssion
            employees.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}"));

            Console.ReadLine();
        }
    }
}
