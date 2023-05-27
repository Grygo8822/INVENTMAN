using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Equipment.Interfaces
{
    public interface IEquipmentSearchAdvancedUseCase
    {
        Task<IEnumerable<Item>> ExecuteAsync(string? name, EquipmentState? state, 
            EquipmentType? type, string? serialNumber, 
            string? employeeName, string? invoiceId, 
            string? vendor, string? manufacturer);
    }
}