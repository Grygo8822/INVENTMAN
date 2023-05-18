using INVENTMAN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Equipment.Interfaces
{
    public interface IInventoryRepository
    {
         Task<IEnumerable<Item>> GetItemsByNameAsync(string name);

        Task AddItemAsync (Item item);
    }
}
