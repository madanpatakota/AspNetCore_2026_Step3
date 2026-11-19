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


        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            IEmployeeService service = new EmployeeService();

            var data = service.GetEmployeeById(id);

            if (data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpPost]
        [Route("CreateEmployee")]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            IEmployeeService service = new EmployeeService();

            var data = service.CreateEmployee(employee);

            return Ok(data);
        }


        [HttpPut]
        [Route("UpdateEmployee/{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee employee)
        {
            IEmployeeService service = new EmployeeService();

            var data = service.UpdateEmployee(id, employee);

            if (data == null)
                return NotFound();

            return Ok(data);
        }


        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            IEmployeeService service = new EmployeeService();

            bool result = service.DeleteEmployee(id);

            if (!result)
                return NotFound();

            return NoContent();
        }


    }
}
