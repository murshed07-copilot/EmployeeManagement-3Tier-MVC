using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BL
{
    public interface ILogging
    {
        void LogError(string message);
    }


    public class TextLog : ILogging
    {
        public void LogError(string message)
        {
            //Create a new text file
            //Write the message to the text file
        }
    }

    public class DatabaseLog : ILogging
    {
        public void LogError(string message)
        {
            //create db connection
            //create a table for error log
            //insert the message into the table
        }
    }

    public class EmailLog : ILogging
    {
        public void LogError(string message)
        {
            //create smtp server connection
            //set to, cc and message
            //send email
        }
    }

    //public class EmployeeController
    //{
    //    //public EmployeeController()
    //    //{
    //    //    TextLog logObject = new TextLog();
    //    //    logObject.LogError("error message");

    //    //    DatabaseLog logObject1 = new DatabaseLog();
    //    //    logObject1.LogError("error message");
    //    //}

    //    ILogging logObect;

    //    public EmployeeController(ILogging logObjParam) //inject DatabaseLog object to this constructor
    //    {
    //        logObect = logObjParam;
    //        logObect.LogError("Error message");
    //    }
    //}
}
