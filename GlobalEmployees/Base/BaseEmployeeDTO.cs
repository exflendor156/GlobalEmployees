
using GlobalEmployees.Core.DAL;
using GlobalEmployees.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GlobalEmployees.Base
{
    public class BaseEmployeeDTO
    {
        public const int HourEmployee = 1;

        public const int MonthlyEmployee = 2;

        public async Task<List<EmployeeRequest>> GetAllEmployeesDTO()
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();

            var employeeList = await employeeDAL.GetAllEmployees();

            return employeeList;
        }

        //Filter by Hourly Employees
        public async Task<EmployeeRequest> GetEmployeesByIdDTO(int id)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();

            var employeeList = await employeeDAL.GetAllEmployees();

            var employee = employeeList.Where(u => u.id == id).FirstOrDefault();

            return employee;
        }
    }
}