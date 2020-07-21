using GlobalEmployees.Abstracts;
using GlobalEmployees.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GlobalEmployees.Core.DTO
{
    public class EmployeeMonthDTO : EmployeeAbstract
    {
        public override EmployeeResponse GetAnnualSalary(EmployeeResponse employeeResponse)
        {
            employeeResponse.annualSalary = employeeResponse.monthlySalary * 12;

            return employeeResponse;
        }
    }
}