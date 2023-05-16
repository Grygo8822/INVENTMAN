using INVENTMAN.Entities;
using INVENTMAN.UseCases.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.DataRepository.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Item> items;

        public InventoryRepository()
        {
            items = new List<Item>()
                {
                    new Item{ ItemId = Guid.NewGuid(), Manufacturer = "HP", Name="EliteBook G8 840", SerialNumber="%AXDsc", Vendor = "MediaMarkt"},
                    new Item{ ItemId = Guid.NewGuid(), Manufacturer = "HP", Name="EliteBook G8 850", SerialNumber="%AXDsc", Vendor = "MediaMarkt"},
                    new Item{ ItemId = Guid.NewGuid(), Manufacturer = "HP", Name="EliteBook G8 840", SerialNumber="%AXDsc", Vendor = "MediaMarkt"}
                };
        }
        public async Task<IEnumerable<Item>> GetItemsByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name))
                return await Task.FromResult(items);

            return items.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
