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
        IEmployeeService service;

        public EmployeeController(IEmployeeService _service)
        {  //_service  (instance of the EmployeeService) 

            //service = new EmployeeService();// Problem of this code... 

            service = _service;

            //1.problem of code  

            //what if i am goign the assign this work to the asp.ent core so then i can reduce my headache
            //2. i want to assign this work new EmployeeService() to the asp.net core

        }

        [HttpGet]
        [Route("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            //var Data = employeeService.GetEmployees();
            List<Employee> Data = service.GetEmployees().ToList();
            return Ok(Data);
        }


        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            //IEmployeeService service = new EmployeeService();

            var data = service.GetEmployeeById(id);

            if (data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpPost]
        [Route("CreateEmployee")]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            //IEmployeeService service = new EmployeeService();

            var data = service.CreateEmployee(employee);

            return Ok(data);
        }


        [HttpPut]
        [Route("UpdateEmployee/{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee employee)
        {
           // IEmployeeService service = new EmployeeService();

            var data = service.UpdateEmployee(id, employee);

            if (data == null)
                return NotFound();

            return Ok(data);
        }


        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            //IEmployeeService service = new EmployeeService();

            bool result = service.DeleteEmployee(id);

            if (!result)
                return NotFound();

            return NoContent();
        }


    }
}
