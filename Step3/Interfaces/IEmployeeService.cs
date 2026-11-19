using Step3.Models;

namespace Step3.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee GetEmployeeById(int id);

        Employee CreateEmployee(Employee employee);

        Employee UpdateEmployee(int id, Employee employee);

        bool DeleteEmployee(int id);
    }
}
