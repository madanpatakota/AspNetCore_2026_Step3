using Microsoft.AspNetCore.Mvc;
using Step3.Services;
using Step3.Models;
using Step3.Interfaces;

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
            IEmployeeService employeeService = new EmployeeService();
            //var Data = employeeService.GetEmployees();
            List<Employee> Data = employeeService.GetEmployees().ToList();
            return Ok(Data);
        }


    }
}
