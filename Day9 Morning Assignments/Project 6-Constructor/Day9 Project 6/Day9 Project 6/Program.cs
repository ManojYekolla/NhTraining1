using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Project_6
{
    class Employee
    {
        public int id;
        public string name; 
        public int salary;
        public static string company = "NationsBenefits";

        public Employee()
        {
            this.id = 0;
            this.name = "null";
            this.salary = 0;
        }

        public Employee(int eid,string ename,int esalary)
        {
            this.id= eid;
            this.name= ename;
            this.salary= esalary;
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
            Employee emp1 = new Employee();
            Employee emp2 = new Employee(1,"manojy",12000);
            emp1.PrintData();

            emp2.PrintData();

            Console.ReadLine();
        }
    }
}
