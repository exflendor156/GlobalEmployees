using GlobalEmployees.Base;
using GlobalEmployees.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GlobalEmployees.Abstracts
{
    public abstract class EmployeeAbstract : BaseEmployeeDTO
    {
        public abstract EmployeeResponse GetAnnualSalary(EmployeeResponse employeeResponse);
    }
}