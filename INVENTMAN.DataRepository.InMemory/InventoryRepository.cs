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

        public Task AddItemAsync(Item item)
        {
            if (items.Any(x => x.ItemId.Equals(item.ItemId)))
                return Task.CompletedTask;

            items.Add(item);

            return Task.CompletedTask;
        }

        public async Task<Item> GetItemByIdAsync(Guid itemId)
        {
            var item =  items.First(x => x.ItemId == itemId);
            var itemCopy = new Item
            {
                SerialNumber = item.SerialNumber,
                Manufacturer = item.Manufacturer,
                Vendor = item.Vendor,
                Name = item.Name
            };

            return await Task.FromResult(itemCopy);
        }

        public async Task<IEnumerable<Item>> GetItemsByNameAsync(string name)
        {
            if (string.IsNullOrEmpty(name))
                return await Task.FromResult(items);

            return items.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public Task UpdateItemAsync(Item item)
        {
            var itemToEdit = items.FirstOrDefault(x => x.ItemId == item.ItemId);
            if(itemToEdit != null)
            {
                itemToEdit.SerialNumber = item.SerialNumber;
                itemToEdit.Manufacturer = item.Manufacturer;
                itemToEdit.Vendor = item.Vendor;
                itemToEdit.Name = item.Name;

            }

            return Task.CompletedTask;
        }
    }
}
