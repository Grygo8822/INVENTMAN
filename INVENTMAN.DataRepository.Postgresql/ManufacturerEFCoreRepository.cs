using INVENTMAN.Entities;
using INVENTMAN.UseCases.Manufacturers.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.DataRepository.Postgresql
{
    public class ManufacturerEFCoreRepository : IManufacturersRepository
    {
        private readonly IDbContextFactory<InventmanContext> contextFacotry;

        public ManufacturerEFCoreRepository(IDbContextFactory<InventmanContext> context)
        {
            contextFacotry = context;
        }

        public async Task AddManufacturerAsync(Manufacturer manufacturer)
        {
            using var db = this.contextFacotry.CreateDbContext();

            if (db.Manufacturers!=null)
            {
                await db.Manufacturers.AddAsync(manufacturer);
                await db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Manufacturer>> GetManufacturerByNameAsync(string manufacturerName)
        {
            using var db = this.contextFacotry.CreateDbContext();
            var manufacturers = db.Manufacturers as IQueryable<Manufacturer>;
            return await manufacturers.Where(x => x.Name.ToLower().IndexOf(manufacturerName.ToLower()) >= 0).ToListAsync();


        }

    }
}
