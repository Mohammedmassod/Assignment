using Assignment.Models;

namespace Assignment.Service
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<Employee> CreateEmployee(Employee employee);
        Task<bool> UpdateEmployee(int id, Employee employee);
        Task<bool> DeleteEmployee(int id);
    }
}
