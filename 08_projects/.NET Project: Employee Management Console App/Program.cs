using System;
using System.Collections.Generic;
using EmployeeManagement.Models;
using EmployeeManagement.Services;

namespace EmployeeManagement
{
  class Program
  {
    static void Main(string[] args)
    {

      EmployeeService employeeService = new EmployeeService();
      DepartmentService departmentService = new DepartmentService();

      departmentService.AddDepartment(new Department { Id = 1, Name = "HR"});
      departmentService.AddDepartment(new Department { Id = 2, Name = "IT"});
      departmentService.AddDepartment(new Department { Id = 3, Name = "Finance"});
      
    }
  }
}
