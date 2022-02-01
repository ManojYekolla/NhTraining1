using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project5
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
            Employee emp1 = new Employee() { id = 1, name = "yekolla", salary = 10000 };
            Console.WriteLine($"id={emp1.id},name={emp1.name},salary={emp1.salary}");
            Console.ReadLine();
        }
    }
}
