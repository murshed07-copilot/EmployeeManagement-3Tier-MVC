using System;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for Class1
/// </summary>
public class EmployeeViewModel
{
    //Data annotations
    [Required]
    public string EmployeeID { get; set; }

    [StringLength(10)]
    public string EmployeeName { get; set; }

    [Range(500, 2000)]
    public int Salary { get; set; }

    public EmployeeViewModel()
    {


    }
}
