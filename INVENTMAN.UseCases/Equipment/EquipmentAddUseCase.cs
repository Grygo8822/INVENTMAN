using INVENTMAN.Entities;
using INVENTMAN.UseCases.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Equipment
{
    public class EquipmentAddUseCase : IEquipmentAddUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public EquipmentAddUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository=inventoryRepository;
        }

        public async Task ExecuteAsync(Item item)
        {
            await this.inventoryRepository.AddItemAsync(item);
        }
    }
}
