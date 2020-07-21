
using GlobalEmployees.Models.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace GlobalEmployees.Core.DAL
{
    public class EmployeeDAL
    {
        public async Task<List<EmployeeRequest>> GetAllEmployees()
        {
            const string restapi = "http://masglobaltestapi.azurewebsites.net/api/Employees";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                using (HttpResponseMessage response = await client.GetAsync(restapi))
                {
                    using (HttpContent content = response.Content)
                    {
                        var result = await content.ReadAsStringAsync();

                        var employee = JsonConvert.DeserializeObject<List<EmployeeRequest>>(result);

                        return employee;
                    }
                }
            }
        }
    }
}