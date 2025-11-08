using HRMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace HRMS.ViewModels
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; } 

        public IEnumerable<SelectListItem>? Departments { get; set; }
        public IEnumerable<SelectListItem>? JobTitles { get; set; }

        public string? DepartmentName => Employee.Department?.DepartmentName;
        public string? JobTitleName => Employee.JobTitle?.TitleName;
    }
}
