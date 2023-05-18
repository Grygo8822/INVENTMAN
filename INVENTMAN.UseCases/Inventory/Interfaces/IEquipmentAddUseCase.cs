using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Inventory.Interfaces
{
    public interface IEquipmentAddUseCase
    {
        Task ExecuteAsync(Item item);
    }
}