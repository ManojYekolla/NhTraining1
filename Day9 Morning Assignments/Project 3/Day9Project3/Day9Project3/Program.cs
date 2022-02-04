using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project3
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NationsBenefits";

        public void ReadData()
        {
            Console.WriteLine("Enter Id Number :");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name Number :");
            name = Console.ReadLine();

            Console.WriteLine("Enter Salary Number :");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintData()
        {
            Console.WriteLine($"id:{id},name:{name},salary:{salary},company:{company}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.ReadData();
            emp.PrintData();

            

            Console.ReadLine();
        }
    }
}
