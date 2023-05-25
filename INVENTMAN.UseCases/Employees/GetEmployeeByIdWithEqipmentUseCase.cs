using INVENTMAN.Entities;
using INVENTMAN.UseCases.Employees.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Employees
{
    public class GetEmployeeByIdWithEqipmentUseCase : IGetEmployeeByIdWithEqipmentUseCase
    {
        private readonly IEmployeeRepository employeeRepository;

        public GetEmployeeByIdWithEqipmentUseCase(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository=employeeRepository;
        }

        public async Task<Employee> ExecuteAsync(Guid employeeId)
        {
            return await employeeRepository.GetEmployeeByIdWithEquipmentAsync(employeeId);
        }
    }
}
