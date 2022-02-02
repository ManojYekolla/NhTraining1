using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Project_4
{
    class Department
    {
        public int id;
        public string name;
        public int empcount;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> dept = new List<Department>()
            {
                new Department() {id=1,name="Gabbar",empcount=28},
                new Department() {id=2,name="Manoj",empcount=50},
                new Department() {id=3,name="Chandhra",empcount=69},
                new Department() {id=3,name="Chandhra",empcount=39},


            };
            // for loop
            for (int i = 0; i < dept.Count; i++)
            {
                if (dept[i].empcount > 50)
                    Console.WriteLine($"id={dept[i].id},name={dept[i].name}");
            }

            //using foreach
            foreach (var p in dept)
            {
                if (p.empcount > 50)
                    Console.WriteLine($"id={p.id},name={p.name}");
            }
            //lamda 
            dept.ToList().Where(p => p.empcount > 50).ToList().ForEach(p => Console.WriteLine($"id={p.id},name={p.name}"));

            //linq

            var result = from p in dept
                         where p.empcount > 50
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"id={p.id},name={p.name}"));
            Console.ReadLine();

        }
    }
}
