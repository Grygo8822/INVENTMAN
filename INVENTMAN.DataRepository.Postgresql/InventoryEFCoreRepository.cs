using INVENTMAN.Entities;
using INVENTMAN.UseCases.Equipment.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.DataRepository.Postgresql
{
    public class InventoryEFCoreRepository : IInventoryRepository
    {
        private readonly IDbContextFactory<InventmanContext> contextFactory;

        public InventoryEFCoreRepository(IDbContextFactory<InventmanContext> contextFactory)
        {
            this.contextFactory=contextFactory;
        }

        public async Task AddItemAsync(Item item)
        {
            using var db = this.contextFactory.CreateDbContext();
            
            await db.Items.AddAsync(item); 
            await db.SaveChangesAsync();
        }

        public async Task<Item> GetItemByIdAsync(Guid itemId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var items = db.Items as IQueryable<Item>;

            return await items.Where(x => x.ItemId == itemId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Item>> GetItemsByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();
            var items = db.Items as IQueryable<Item>;

            return await items.Where(x => x.Name.ToLower().IndexOf(name.ToLower()) >= 0).ToListAsync();


        }

        public Task UpdateItemAsync(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
