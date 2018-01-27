using System;
using System.Collections.Generic;
using System.Text;
using Week11.Models;

namespace Week11.Services
{
     public class EmployeeServices
    {
        public List<Employee> GetEmployees()
        {
            var list = new List<Employee>
            {
                new Employee
                {
                    Name="FirstName",
                    Department="Computer Science"
                },
                new Employee
                {
                    Name="SecondName",
                    Department="Electronics"
                },
                new Employee
                {
                    Name="ThirdName",
                    Department="Applied"
                },
                new Employee
                {
                    Name="FourthName",
                    Department="Electrical"
                }


            };
            return list;
        }
    }
}
 