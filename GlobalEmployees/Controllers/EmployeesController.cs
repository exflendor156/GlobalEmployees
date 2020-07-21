using GlobalEmployees.Abstracts;
using GlobalEmployees.Core.BusinessLogic;
using GlobalEmployees.Models.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GlobalEmployees.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet("GetEmployees")]
        public async Task<List<EmployeeResponse>> GetEmployees()
        {
            EmployeesBL employeeBL = new EmployeesBL();
            return await employeeBL.GetAllEmployeeContract();
        }

        [HttpGet("GetEmployeeByID/{id}")]
        public async Task<List<EmployeeResponse>> GetEmployeeById(int id)
        {
            EmployeesBL employeeBL = new EmployeesBL();
            return await employeeBL.GetEmployeeById(id);    
        }
    }
}