﻿using INVENTMAN.Entities;
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
        private readonly IEquipmentRepository inventoryRepository;
        public EquipmentEditUseCase(IEquipmentRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;

        }

        public async Task ExecuteAsync(Item item)
            {
            if (item.ItemState == EquipmentState.Unassigned && item.EmployeeId != null)
                item.ItemState = EquipmentState.Assigned;
            else if (item.ItemState == EquipmentState.Assigned && item.EmployeeId == null)
                item.ItemState = EquipmentState.Unassigned;
            await inventoryRepository.UpdateItemAsync(item);
        }


    }
}
