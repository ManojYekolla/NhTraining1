using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project_4_d_
{
    class Department
    {
        private int id;
        private string name;
        private long mobile;
        private string branch;

        public void ReadDepartment()
        {
            Console.WriteLine("Enter Your Department Id : ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your Department name : ");
            name = Console.ReadLine();

            Console.WriteLine("enter your Department mobile  :");
            mobile = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your  Department branch :");
            branch = Console.ReadLine();
        }
        public void PrintDepartment()
        {
            Console.WriteLine($"id={id},name={name},mobile={mobile},branch={branch}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();   
            department.ReadDepartment();   
            department. PrintDepartment();
            Console.ReadLine();
        }
    }
}
