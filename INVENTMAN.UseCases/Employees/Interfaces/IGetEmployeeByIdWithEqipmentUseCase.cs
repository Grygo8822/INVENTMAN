using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Employees.Interfaces
{
    public interface IGetEmployeeByIdWithEqipmentUseCase
    {
        Task<Employee> ExecuteAsync(Guid employeeId);
    }
}