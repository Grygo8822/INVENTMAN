using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Employees.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task AddEmployeeAsync(Employee employee);

        public Task<IEnumerable<Employee>> GetEmployeesByNameAsync(string employeeName);

        public Task<Employee> GetEmployeeByIdAsync(Guid employeeId);

        public Task<Employee> GetEmployeeByIdWithEquipmentAsync(Guid employeeId);
    }
}