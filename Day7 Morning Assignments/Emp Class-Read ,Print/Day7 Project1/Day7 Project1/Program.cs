using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Project1
{
    class Employee
    {
        private int id;
        private string name; 
        private int salary;

        public void ReadEmployee()
        {
            Console.WriteLine("Enter Id Num :");
            id =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Your Name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your Salary :");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Id={id},Name={name},Salary={salary}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ReadEmployee();
            emp1.PrintEmployee();

            Console.ReadLine();
        }
        
    }
}
