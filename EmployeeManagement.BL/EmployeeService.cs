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

        public List<EmployeeDO> GetAll()   // how can I call EmployeeDataService's - GetAllEmployees method here?
        {
            List<EmployeeDO> employeeList = new List<EmployeeDO>();

            try
            {
                employeeList = dataService.GetAllEmployees();
            }
            catch (Exception ex)
            {
                logMessage.LogError(ex.Message);
            }
            
            return employeeList;

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


