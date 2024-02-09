using Assignment.Models;
using Assignment.Repository;

namespace Assignment.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _employeeRepository.GetAll();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _employeeRepository.GetById(id);
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            return await _employeeRepository.Add(employee);
        }

        public async Task<bool> UpdateEmployee(int id, Employee employee)
        {
            employee.Id = id;
            return await _employeeRepository.Update(employee);
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            return await _employeeRepository.Delete(id);
        }
    }
}
