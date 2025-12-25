using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class EmployeeDO
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int Salary { get; set; }

    }
}
