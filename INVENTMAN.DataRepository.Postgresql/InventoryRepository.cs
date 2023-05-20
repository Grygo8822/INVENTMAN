using INVENTMAN.Entities;
using INVENTMAN.UseCases.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.DataRepository.Postgresql
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly InventmanContext db;

        public InventoryRepository(InventmanContext db)
        {
            this.db = db;
        }
        public async Task AddItemAsync(Item item)
        {
            await db.Items.AddAsync(item);

            await db.SaveChangesAsync();
        }

        public async Task<Item> GetItemByIdAsync(Guid itemId)
        {
            var item =  await db.Items.FindAsync(itemId);

            if (item == null)
                return new Item();

            return item;
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
