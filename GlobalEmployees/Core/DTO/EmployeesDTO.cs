
using GlobalEmployees.Base;
using GlobalEmployees.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GlobalEmployees.Core.DTO
{
    public class EmployeesDTO : BaseEmployeeDTO
    {
        public async Task<List<EmployeeResponse>> GetAllAnnualSalary()
        {
            var request = await GetAllEmployeesDTO();

            var response = from r in request
                           select new EmployeeResponse{
                           id = r.id,
                           name = r.name,
                           contractTypeName = r.contractTypeName,
                           roleId = r.roleId,
                           roleDescription = r.roleName,
                           hourlySalary = r.hourlySalary,
                           monthlySalary = r.monthlySalary,
                           annualSalary = 0
                           };

            return response.ToList();
        }

        public async Task<EmployeeResponse> GetEmployeeById(int id)
        {
            var request = await GetEmployeesByIdDTO(id);

            EmployeeResponse employeeResponse = new EmployeeResponse();

            if (request != null)
            {
                employeeResponse.id = request.id;
                employeeResponse.name = request.name;
                employeeResponse.contractTypeName = request.contractTypeName;
                employeeResponse.roleId = request.roleId;
                employeeResponse.roleDescription = request.roleDescription;
                employeeResponse.hourlySalary = request.hourlySalary;
                employeeResponse.monthlySalary = request.monthlySalary;
                return employeeResponse;
            }
            else
            {
                return null;
            }
            
        }
    }
}