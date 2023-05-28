using INVENTMAN.Entities;
using INVENTMAN.UseCases.Employees.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.DataRepository.Postgresql
{
    public class EmployeeEFCoreRepository : IEmployeeRepository
    {
        private readonly IDbContextFactory<InventmanContext> contextFacotry;

        public EmployeeEFCoreRepository(IDbContextFactory<InventmanContext> context)
        {
            contextFacotry = context;
        }
        public async Task AddEmployeeAsync(Employee employee)
        {
            using var db = this.contextFacotry.CreateDbContext();
            if(db.Employees != null)
            {
                await db.Employees.AddAsync(employee);
                await db.SaveChangesAsync();
            }
           

        }

        public async Task<Employee> GetEmployeeByIdAsync(Guid employeeId)
        {
            using var db = this.contextFacotry.CreateDbContext();
            var employees = db.Employees as IQueryable<Employee>;

            return await employees.Where(x => x.EmployeeId == employeeId).FirstOrDefaultAsync() ?? new Employee();


        }

        public async Task<Employee> GetEmployeeByIdWithEquipmentAsync(Guid employeeId)
        {
            using var db = this.contextFacotry.CreateDbContext();
            var employees = db.Employees as IQueryable<Employee>;

            return await employees.Where(x => x.EmployeeId == employeeId).FirstOrDefaultAsync() ?? new Employee();
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByNameAsync(string employeeName)
        {
            using var db = this.contextFacotry.CreateDbContext();

            var employees = db.Employees as IQueryable<Employee>;

            return await employees.Where(x => x.Name.ToLower().IndexOf(employeeName.ToLower()) >= 0).ToListAsync();
        }
    }
}
