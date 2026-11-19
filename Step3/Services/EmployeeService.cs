using Step3.Interfaces;
using Step3.Models;
using System.Xml.Linq;

namespace Step3.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> _employees = new()
                {
                    new Employee { Id = 1, Name = "Ravi" },
                    new Employee { Id = 2, Name = "Kiran" }
                };
        public Employee GetEmployeeById(int id)
        {
            //throw new NotImplementedException();
            return _employees.Where(e => e.Id == id).FirstOrDefault();
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public Employee CreateEmployee(Employee employee)
        {
            //employee.Id = employees.Count == 0 ? 1 : employees.Max(e => e.Id) + 1;
            if (_employees.Count == 0)
            {
                employee.Id = 1;
            }
            else
            {
                int MaxempID = _employees.Max(e => e.Id);
                employee.Id = MaxempID + 1;
            }

            _employees.Add(employee);

            return employee;
        }
       
        public Employee UpdateEmployee(int id, Employee employee)
        {
            Employee? existingEmployee = _employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
            {
                return null;
            }

            existingEmployee.Name = employee.Name;
            return existingEmployee;
        }

        public bool DeleteEmployee(int id)
        {
            Employee? existingEmployee = _employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
            {
                return false;
            }

            _employees.Remove(existingEmployee);
            return true;
        }

    }
}
