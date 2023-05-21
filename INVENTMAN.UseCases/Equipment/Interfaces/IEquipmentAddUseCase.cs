using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Equipment.Interfaces
{
    public interface IEquipmentAddUseCase
    {
        Task ExecuteAsync(Item item);
    }
}