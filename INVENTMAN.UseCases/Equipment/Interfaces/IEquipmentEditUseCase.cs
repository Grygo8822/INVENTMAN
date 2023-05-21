using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Equipment.Interfaces
{
    public interface IEquipmentEditUseCase
    {
        Task ExecuteAsync(Item item);
    }
}