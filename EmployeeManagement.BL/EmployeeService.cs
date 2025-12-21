using EmployeeManagement.DL;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BL
{
    public class EmployeeService : IEmployeeService

    {
        ILogging logMessage;
        IEmployeeDataService dataService;
        public EmployeeService(ILogging logObjParam, IEmployeeDataService dataServicePrem) //inject (dependency injection) DatabaseLog object to this "constructor"
        {
            logMessage = logObjParam;
            dataService = dataServicePrem;

            logMessage.LogError("Error message from EmployeeService");
            
        }

        public List<Employee> GetAll()   // how can I call EmployeeDataService's - GetAllEmployees method here?
        {
            var employee = dataService.GetAllEmployees();
            logMessage.LogError("Error message from EmployeeDataService");
            return employee;

            //return list;
        }

        //public ILogging GetLogFramework()
        //{
        //    //TextLog logObject = new TextLog();
        //    //return logObject;

        //    return new TextLog();
        //}
    }
}


