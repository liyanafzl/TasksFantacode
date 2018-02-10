using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Plugin.RestClient;
using Week11.Models;

namespace Week11.Services
{
     public class EmployeeServices
    {
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            RestClient<Employee> restClient = new RestClient<Employee>();
            var employeesList = await restClient.GetAsync();
            return employeesList;
        }
    
    }
}
 