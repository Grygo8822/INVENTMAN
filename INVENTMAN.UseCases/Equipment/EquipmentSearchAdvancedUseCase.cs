using INVENTMAN.Entities;
using INVENTMAN.UseCases.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Equipment
{
    public class EquipmentSearchAdvancedUseCase
    {
        private readonly IInventoryRepository ivnetnoryRepository;

        public EquipmentSearchAdvancedUseCase(IInventoryRepository ivnetnoryRepository)
        {
            this.ivnetnoryRepository=ivnetnoryRepository;
        }

        public async Task<IEnumerable<Item>> ExecuteAsync(string? name, EquipmentState? state, 
            EquipmentType? type, string? serialNumber, 
            string? employeeName,  string? invoicId, 
            Vendor? vendor, Manufacturer? manufacturer)
        {

        }
    }
}
