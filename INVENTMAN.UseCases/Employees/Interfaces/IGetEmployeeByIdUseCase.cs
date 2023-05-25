using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Employees.Interfaces
{
    public interface IGetEmployeeByIdUseCase
    {
        Task<Employee> ExecuteAsync(Guid employeeId);
    }
}