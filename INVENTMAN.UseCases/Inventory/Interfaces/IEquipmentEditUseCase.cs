using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Inventory.Interfaces
{
    public interface IEquipmentEditUseCase
    {
        Task ExecuteAsync(Item item);
    }
}