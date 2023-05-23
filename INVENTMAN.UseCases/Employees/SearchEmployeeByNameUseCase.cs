using INVENTMAN.Entities;
using INVENTMAN.UseCases.Employees.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Employees
{
    public class SearchEmployeeByNameUseCase : ISearchEmployeeByNameUseCase
    {
        private readonly IEmployeeRepository employeeRepository;

        public SearchEmployeeByNameUseCase(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository=employeeRepository;
        }

        public async Task<IEnumerable<Employee>> ExecuteAsync(string name)
        {
            return await employeeRepository.GetEmployeesByNameAsync(name);
        }
    }
}
