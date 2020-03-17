using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees()
        {
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "JohnH@pragmthech.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Department1"},
                PhotoPath = "images/john.png"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Mary",
                LastName = "Martin",
                Email = "MaryM@pragmthech.com",
                DateOfBirth = new DateTime(1988, 7, 12),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 2, DepartmentName = "Department2" },
                PhotoPath = "images/mary.png"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Kendra",
                LastName = "Pothard",
                Email = "KendraP@pragmthech.com",
                DateOfBirth = new DateTime(1977, 2, 4),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 3, DepartmentName = "Department3" },
                PhotoPath = "images/kendra.png"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Carlos",
                LastName = "Devops",
                Email = "CarlosD@pragmthech.com",
                DateOfBirth = new DateTime(1986, 2, 8),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 4, DepartmentName = "Department4" },
                PhotoPath = "images/carlos.png"
            };


            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
