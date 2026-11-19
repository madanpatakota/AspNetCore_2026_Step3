using Microsoft.AspNetCore.Mvc;
using Step3.Services;
using Step3.Models;

namespace Step3.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            EmployeeService employeeService = new EmployeeService();
            //var Data = employeeService.GetEmployees();
            List<Employee> Data = employeeService.GetEmployees().ToList();
            return Ok(Data);
        }


    }
}
