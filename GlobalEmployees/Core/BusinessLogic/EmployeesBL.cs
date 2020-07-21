
using GlobalEmployees.Abstracts;
using GlobalEmployees.Core.DTO;
using GlobalEmployees.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GlobalEmployees.Core.BusinessLogic
{
    public class EmployeesBL 
    {
        public const int HourEmployee = 1;

        public const int MonthlyEmployee = 2;

        public static EmployeeAbstract CalculateAnnualSalary(EmployeeResponse employeeResponse)
        {
            switch (employeeResponse.id)
            {
                case HourEmployee:
                    return new EmployeeHourDTO();
                case MonthlyEmployee:
                    return new EmployeeMonthDTO();
                default: return null;
            }
        }

        public async Task<List<EmployeeResponse>> GetAllEmployeeContract()
        {
            EmployeesDTO employeesDTO = new EmployeesDTO();

            var employeesResponse = await employeesDTO.GetAllAnnualSalary();

            if (employeesResponse != null) 
            {
                foreach (var e in employeesResponse)
                {
                    EmployeeAbstract employeeAbstract = CalculateAnnualSalary(e);
                    employeeAbstract.GetAnnualSalary(e);
                }
            }
            return employeesResponse;
        }
        public async Task<List<EmployeeResponse>> GetEmployeeById(int id)
        {
            List<EmployeeResponse> responseList = new List<EmployeeResponse>();

            EmployeesDTO employeesDTO = new EmployeesDTO();

            var employeesResponse = await employeesDTO.GetEmployeeById(id);

            if (employeesResponse != null)
            {
                EmployeeAbstract employeeAbstract = CalculateAnnualSalary(employeesResponse);

                employeeAbstract.GetAnnualSalary(employeesResponse);

                responseList.Add(employeesResponse);

                return responseList;
            }
            else
            {
                return null;
            }
           
        }

    }
}