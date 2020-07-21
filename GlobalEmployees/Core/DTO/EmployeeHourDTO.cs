using GlobalEmployees.Abstracts;
using GlobalEmployees.Models.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace GlobalEmployees.Core.DTO
{
    public class EmployeeHourDTO : EmployeeAbstract
    {
        public override EmployeeResponse GetAnnualSalary(EmployeeResponse employeeResponse)
        {
            employeeResponse.annualSalary = 120 * employeeResponse.hourlySalary * 12;

            return employeeResponse;
        }
    }
}