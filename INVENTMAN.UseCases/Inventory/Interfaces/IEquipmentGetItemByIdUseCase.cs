using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Inventory.Interfaces
{
    public interface IEquipmentGetItemByIdUseCase
    {
        Task<Item> ExecuteAsync(Guid itemId);
    }
}