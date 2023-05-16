using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Inventory.Interfaces
{
    public interface IEquipmentSearchUseCase
    {
        Task<IEnumerable<Item>> ExecuteAsync(string name = "");
    }
}