using INVENTMAN.Entities;
using INVENTMAN.UseCases.Vendors.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.DataRepository.Postgresql
{
    public class VendorEFCoreRepository : IVendorRepository
    {
        private readonly IDbContextFactory<InventmanContext> contextFacotry;

        public VendorEFCoreRepository(IDbContextFactory<InventmanContext> context)
        {
            contextFacotry = context;
        }

        public async Task AddVendorAsync(Vendor vendor)
        {
            using var db = this.contextFacotry.CreateDbContext();

            if (db.Vendors!=null)
            {
                await db.Vendors.AddAsync(vendor);
                await db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Vendor>> GetVendorByNameAsync(string vendorName)
        {
            using var db = this.contextFacotry.CreateDbContext();
            var vendors = db.Vendors as IQueryable<Vendor>;
            return await vendors.Where(x => x.Name.ToLower().IndexOf(vendorName.ToLower()) >= 0).ToListAsync();


        }
    }
}
