using System;
using System.IO;
using System.Collections.Generic;

namespace DataAcessesLayer
{
    public static class DALEmployee
    {
        public static string filePath = @"F:\Nb HealthCare Tech\Day-22 Morning Assignments\EmployeesData\Employee.txt";

       
    public static bool AddEmployee(int empId, string empName, int empSalary, int
   empAge)
        {
            try
            {
                string textcontent = string.Concat(empId, ',', empName, ',', empSalary,
               ',', empAge);
                File.AppendAllText(filePath, textcontent + Environment.NewLine);
                return true;
            }
            catch (Exception)
            { return false; }
        }
        public static List<String> GetEmployeesById(int id)
        {
            var allEmployees = File.ReadAllLines(filePath);
            //bool isFound;
            List<string> employeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (Convert.ToInt32(empDetails[0]) == id)
                {
                    //isFound = true;
                    employeeFound.Add(employee);
                    break;
                }
            }
            return employeeFound;
        }
        public static List<String> GetEmployeesByName(string name)
        {
            var allEmployees = File.ReadAllLines(filePath);
            List<String> employeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (empDetails[1].Contains(name))
                {
                    employeeFound.Add(employee);
                }
            }
            return employeeFound;
        }
        public static string[] GetAllEmployees()
        {
            var allEmplyees = File.ReadAllLines(filePath);
            return allEmplyees;
        }
    }
}