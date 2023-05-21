using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Equipment.Interfaces
{
    public interface IEquipmentGetItemByIdUseCase
    {
        Task<Item> ExecuteAsync(Guid itemId);
    }
}