using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BL
{
    public class EmployeeService
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> list = new List<Employee>();

            Employee model1 = new Employee();
            model1.EmployeeName = "Vishnu";
            model1.EmployeeID = "1";
            model1.Salary = 1000;

            list.Add(model1);

            Employee model2 = new Employee();
            model2.EmployeeName = "Sayful";
            model2.EmployeeID = "2";
            model2.Salary = 2000;

            list.Add(model2);

            return list;
        }
    }
}
