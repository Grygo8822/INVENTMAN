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
