using System;
using System.Collections.Generic;

namespace EmployeeManagement.DL.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? EmployeeName { get; set; }

    public int? Salary { get; set; }

    public DateTime? CreatedDate { get; set; }
}
