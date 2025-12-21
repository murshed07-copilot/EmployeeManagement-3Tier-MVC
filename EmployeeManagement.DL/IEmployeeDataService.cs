using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeManagement.DL
{
    public interface IEmployeeDataService  // Changed access modifier to public "from the internal"
    {
        List<Employee> GetAllEmployees();
    }

}