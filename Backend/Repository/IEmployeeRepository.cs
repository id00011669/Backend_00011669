using Backend.Model;

namespace Backend.Repository
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int Id);
        IEnumerable<Employee> GetEmployees();
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
  
    }
}
