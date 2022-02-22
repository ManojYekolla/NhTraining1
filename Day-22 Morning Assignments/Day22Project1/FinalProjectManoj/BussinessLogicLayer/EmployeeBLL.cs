using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessesLayer;

namespace BussinessLogicLayer
{
    public class EmployeeBLL
    {
        public static bool AddEmployee(int empId, string empName, int empSalary, int
       empAge)
        {
            // Todo Validations
            var result = DALEmployee.AddEmployee(empId, empName, empSalary, empAge);
            return result;
        }
        public static List<String> GetEmployeesById(int id)
        {
            var result = DALEmployee.GetEmployeesById(id);
            return result;
        }
        public static List<String> GetEmployeesByName(string name)
        {
            var result = DALEmployee.GetEmployeesByName(name);
            return result;
        }
        public static string[] GetAllEmployees()
        {
            var result = DALEmployee.GetAllEmployees();
            return result;
        }
    }
}