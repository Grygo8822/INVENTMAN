using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Employees.Interfaces
{
    public interface ISearchEmployeeByNameUseCase
    {
        Task<IEnumerable<Employee>> ExecuteAsync(string name = "");
    }
}