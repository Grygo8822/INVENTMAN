using INVENTMAN.Entities;
using INVENTMAN.UseCases.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Equipment
{
    public class EquipmentSearchAdvancedUseCase : IEquipmentSearchAdvancedUseCase
    {
        private readonly IEquipmentRepository equipmentRepository;

        public EquipmentSearchAdvancedUseCase(IEquipmentRepository equipmentRepository)
        {
            this.equipmentRepository=equipmentRepository;
        }

        public async Task<IEnumerable<Item>> ExecuteAsync(string? name, EquipmentState? state,
            EquipmentType? type, string? serialNumber,
            string? employeeName, string? invoiceId,
            string? vendor, string? manufacturer)
        {
            return await this.equipmentRepository.GetEquipmentAsync(name, state, type,
                serialNumber, employeeName, invoiceId, vendor, manufacturer);
        }
    }
}
