using INVENTMAN.Entities;
using INVENTMAN.UseCases.Equipment.Interfaces;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.DataRepository.Postgresql
{
    public class EquipmentEFCoreRepository : IEquipmentRepository
    {
        private readonly IDbContextFactory<InventmanContext> contextFactory;

        public EquipmentEFCoreRepository(IDbContextFactory<InventmanContext> contextFactory)
        {
            this.contextFactory=contextFactory;
        }

        public async Task AddItemAsync(Item item)
        {
            using var db = this.contextFactory.CreateDbContext();
            
            await db.Items.AddAsync(item); 
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Item>> GetEquipment(string? name, 
            EquipmentState? state, EquipmentType? type,
            string? serialNumber, string? employeeName,
            string? invoiceId, string? vendor, string? manufacturer)
        {
            using var db = this.contextFactory.CreateDbContext();
            var items = db.Items.Include(x=>x.Employee).Include(x => x.Manufacturer).Include(x=> x.Vendor) as IQueryable<Item>;

            var query = from it in items
                        where
                            (string.IsNullOrWhiteSpace(name) || it.Name.ToLower().IndexOf(name.ToLower()) >= 0) &&
                            (!state.HasValue || it.ItemState.Equals(state.Value)) &&
                            (!type.HasValue || it.ItemType.Equals(type.Value)) &&
                            (string.IsNullOrWhiteSpace(serialNumber) || it.SerialNumber.ToLower().IndexOf(serialNumber.ToLower()) >= 0) &&
                            (string.IsNullOrWhiteSpace(vendor) || it.Vendor!.Name.ToLower().IndexOf(vendor.ToLower()) >= 0)&&
                            (string.IsNullOrWhiteSpace(manufacturer) || it.Manufacturer!.Name.ToLower().IndexOf(manufacturer.ToLower()) >= 0)&&
                            (string.IsNullOrWhiteSpace(employeeName) || it.Employee!.Name.ToLower().IndexOf(employeeName.ToLower()) >= 0)&&
                            (string.IsNullOrWhiteSpace(invoiceId) || it.InvoiceId.ToLower().IndexOf(invoiceId.ToLower()) >= 0)
                        select it;

            return await query.ToListAsync();
        }

        public async Task<Item> GetItemByIdAsync(Guid itemId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var items = db.Items as IQueryable<Item>;

            return await items
                .Include(x => x.Employee)
                .Include(x => x.Manufacturer)
                .Include(x => x.Vendor)
                .Where(x => x.ItemId == itemId)
                .FirstOrDefaultAsync() ?? new Item();
        }

        public async Task<IEnumerable<Item>> GetItemsByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();

            var items = db.Items as IQueryable<Item>;

        //TODO: Change this if you can to a bool if we want to include manufacturers
            return await items
                .Include(x => x.Employee)
                .Include(x => x.Manufacturer)
                .Where(x => x.Name.ToLower()
                .IndexOf(name.ToLower()) >= 0)
                .ToListAsync();


        }

        public async Task UpdateItemAsync(Item item)
        {
            using var db = this.contextFactory.CreateDbContext();
            var items = db.Items as IQueryable<Item>;

            var itemToEdit = await items
                .Where(x => x.ItemId == item.ItemId)
                .FirstOrDefaultAsync();

            if(itemToEdit != null)
            {
                itemToEdit.SerialNumber = item.SerialNumber;
                itemToEdit.VendorId = item.VendorId;
                itemToEdit.ManufacturerId = item.ManufacturerId;
                itemToEdit.Description = item.Description;
                itemToEdit.EmployeeId = item.EmployeeId;
                itemToEdit.InvoiceId = item.InvoiceId;
                itemToEdit.ItemState = item.ItemState;
                itemToEdit.ItemType = item.ItemType;
                itemToEdit.EanCode = item.EanCode;
                itemToEdit.EndOfWarranty = item.EndOfWarranty;
                itemToEdit.Name = item.Name;

                await db.SaveChangesAsync();

            }

        }
    }
}
