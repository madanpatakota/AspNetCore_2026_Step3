using Step3.Interfaces;
using Step3.Models;

namespace Step3.Services
{
    public class EmployeeService : IEmployeeService
    {

        public List<Employee> GetEmployees()
        {
            return new List<Employee>
                {
                    new Employee { Id = 1, Name = "Ravi" },
                    new Employee { Id = 2, Name = "Kiran" }
                };
        }

    }
}
