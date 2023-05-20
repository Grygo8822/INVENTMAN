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
        //private readonly InventmanContext db;

        //public InventoryEFCoreRepository(InventmanContext db)
        //{
        //    this.db = db;
        //}
        //public async Task AddItemAsync(Item item)
        //{
        //    await db.Items.AddAsync(item);

        //    await db.SaveChangesAsync();
        //}

        //public async Task<Item> GetItemByIdAsync(Guid itemId)
        //{
        //    var item =  await db.Items.FindAsync(itemId);

        //    if (item == null)
        //        return new Item();

        //    return item;
        //}

        //public async Task<IEnumerable<Item>> GetItemsByNameAsync(string name)
        //{
        //    var items = db.Items as IQueryable<Item>;

        //    if(!string.IsNullOrEmpty(name))
        //    {
        //        name = name.Trim();
        //        items = items.Where(x => x.Name.Contains(name));
        //    }

        //    return await items.OrderBy(x => x.SerialNumber).ToListAsync();

        //}

        //public async Task UpdateItemAsync(Item item)
        //{
        //    return;
        //}
        public Task AddItemAsync(Item item)
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetItemByIdAsync(Guid itemId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Item>> GetItemsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemAsync(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
