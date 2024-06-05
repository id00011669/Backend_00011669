using Backend.DBConfig;
using Backend.Model;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _dbContext;
        public EmployeeRepository(EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateEmployee(Employee employee)
        {
            _dbContext.Add(employee);
            _dbContext.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employee = _dbContext.Employee.Find(id);
            _dbContext.Employee.Remove(employee);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _dbContext.Employee.ToList();
        }

        public Employee GetEmployeeById(int Id)
        {
            var employee = _dbContext.Employee.Find(Id);
            return employee;
        }

        public void UpdateEmployee(Employee employee)
        {
            _dbContext.Entry(employee).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
