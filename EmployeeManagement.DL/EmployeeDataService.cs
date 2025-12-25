using EmployeeManagement.DL.Models;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DL
{
    public class  EmployeeDataService : IEmployeeDataService
    {
        EmployeeManagementContext _dbContext;

        public EmployeeDataService(EmployeeManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<EmployeeDO> GetAllEmployees()
        {
            List<Employee> dbEmployees = _dbContext.Employees.ToList();

            List<EmployeeDO> doEmployees = new List<EmployeeDO>();
            foreach (var dbEmp in dbEmployees)
            {
                EmployeeDO doE = new EmployeeDO();
                doE.EmployeeID = dbEmp.EmployeeNumber ?? string.Empty;
                doE.EmployeeName = dbEmp.EmployeeName ?? string.Empty;
                doE.Salary = dbEmp.Salary ?? 0;

                doEmployees.Add(doE);
            }

            return doEmployees;
        }

        //public List<EmployeeDO> GetAllEmployees()
        //{
        //    List<EmployeeDO> list = new List<EmployeeDO>();

        //    EmployeeDO model1 = new EmployeeDO();
        //    model1.EmployeeName = "Vishnu";
        //    model1.EmployeeID = "1";
        //    model1.Salary = 1000;

        //    list.Add(model1);

        //    EmployeeDO model2 = new EmployeeDO();
        //    model2.EmployeeName = "Sayful";
        //    model2.EmployeeID = "2";
        //    model2.Salary = 2000;

        //    return list;
        //}
    }
}
