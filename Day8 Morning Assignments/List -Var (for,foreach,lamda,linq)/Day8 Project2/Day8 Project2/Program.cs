using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Project2
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
            List<Employee> emp = new List<Employee>() {
            new Employee() { id = 1, name = "manoj Yekolla", salary = 20000 },
            new Employee() { id = 2, name = "murali", salary = 10000 },
            new Employee() { id = 3, name = "Nithesh", salary = 5000 },
            new Employee() { id = 4, name = "Munaswamy", salary = 27000 },
            };
            //using for loop
            
            for (int i=0; i< emp.Count;i++)
            {
                Console.WriteLine($"id={emp[i].id},name={emp[i].name},salary={emp[i].salary}");

            }

            //using foreach loop
            foreach (var e in emp)
            {
                Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}");
            }

            //using lamda expression
            emp.ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},salary={e.salary}"));

            //using Linq
            var result = from e in emp

                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"id={e.id},salary={e.salary},name={e.name}"));
            Console.ReadLine();

        }
    }
}
