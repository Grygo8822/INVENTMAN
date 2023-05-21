using INVENTMAN.Entities;
using INVENTMAN.UseCases.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Equipment
{
    public class EquipmentGetItemByIdUseCase : IEquipmentGetItemByIdUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public EquipmentGetItemByIdUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository=inventoryRepository;
        }

        public async Task<Item> ExecuteAsync(Guid itemId)
        {
            return await inventoryRepository.GetItemByIdAsync(itemId);
        }

    }
}
