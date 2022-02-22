using System;
using BussinessLogicLayer;


namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string choice;
            int ch;
            do
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Welecome to Employement Management Application");
                Console.WriteLine("------------------------------------------------");

                Console.WriteLine(" 1. Add Employee Details");
                Console.WriteLine(" 2. Search Employee By Id");
                Console.WriteLine(" 3. Search Employee By Name");
                Console.WriteLine(" 4. Display All Employee Details");
                Console.Write(" Enter Your Choice : ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        SearchEmployeeById();
                        break;
                    case 3:
                        SearchEmployeeByName();
                        break;
                    case 4:
                        DisplayAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.Write("Do You Want to Continue  (y/n): ");
             
                choice = Console.ReadLine();
               
            } while (choice == "y" || choice == "Y");
            
            
            Console.ReadLine();
        }

        public static void AddEmployee()
        {
            int id, salary, age;
            string name;
            Console.Write("Enter  employee Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  employee Name : ");
            name = Console.ReadLine();
            Console.Write("Enter  employee Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  employee Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            var result = EmployeeBLL.AddEmployee(id, name, salary, age);
            if (result)
            {
              
                Console.WriteLine(" Employee Details Saved Succesfully");
               
            }
            else
            {
                Console.WriteLine("Something went worng ");
            }
        }
        public static void SearchEmployeeById()
        {
            int id;
            Console.Write("Enter your Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            var result = EmployeeBLL.GetEmployeesById(id);
            if (result.Count == 0)
            {
            
                Console.WriteLine(" No Records Found");
             
            }
            else
            {
                Console.WriteLine(" Successfull saved Id details : ");
                
                result.ForEach(e => Console.WriteLine("\t{0}", e));
                
            }
        }

        public static void SearchEmployeeByName()
        {
            string name;
            Console.Write("Enter your Name : ");
            name = Console.ReadLine();
            var result = EmployeeBLL.GetEmployeesByName(name);
            if (result.Count == 0)
            {

                Console.WriteLine("No Records are Found");
               
                
            }
            else
            {
                Console.WriteLine("Display your Name ");
               
                
                result.ForEach(emp => Console.WriteLine( emp));
                
            }
        }
        public static void DisplayAllEmployees()
        {
            var employees = EmployeeBLL.GetAllEmployees();
            
            Console.WriteLine(" Display All Employee Deatials");
           
            
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
            
        }
    }
}