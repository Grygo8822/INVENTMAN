using INVENTMAN.Entities;
using INVENTMAN.UseCases.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Equipment
{
    public class EquipmentEditUseCase : IEquipmentEditUseCase
    {
        private readonly IInventoryRepository inventoryRepository;
        public EquipmentEditUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;

        }

        public async Task ExecuteAsync(Item item)
        {
            await inventoryRepository.UpdateItemAsync(item);
        }


    }
}
