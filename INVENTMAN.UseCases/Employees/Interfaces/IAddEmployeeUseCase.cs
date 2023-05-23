using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Employees.Interfaces
{
    public interface IAddEmployeeUseCase
    {
        Task AddEmployeeAsync(Employee employee);
    }
}