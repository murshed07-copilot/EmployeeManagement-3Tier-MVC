using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DL
{
    internal interface IEmployeeData
    {
        List<Employee> GetAllEmployees();
    }
}
