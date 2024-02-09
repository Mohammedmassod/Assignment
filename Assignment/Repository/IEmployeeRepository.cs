using Assignment.Models;
using Assignment.DTO;
namespace Assignment.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task<Employee> Add(Employee employee);
        Task<bool> Update(Employee employee);
        Task<bool> Delete(int id);
    }
}
