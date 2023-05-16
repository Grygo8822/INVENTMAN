using INVENTMAN.Entities;
using INVENTMAN.UseCases.Equipment.Interfaces;
using INVENTMAN.UseCases.Inventory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Equipment
{
    public class EquipmentSearchUseCase : IEquipmentSearchUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public EquipmentSearchUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository=inventoryRepository;
        }

        public async Task<IEnumerable<Item>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetItemsByNameAsync(name);
        }
    }
}
