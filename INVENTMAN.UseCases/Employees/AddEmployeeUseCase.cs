using INVENTMAN.Entities;
using INVENTMAN.UseCases.Employees.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Employees
{
    public class AddEmployeeUseCase : IAddEmployeeUseCase
    {
        private readonly IEmployeeRepository employeeRepository;

        public AddEmployeeUseCase(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository=employeeRepository;
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
             await employeeRepository.AddEmployeeAsync(employee);
        }
    }
}
