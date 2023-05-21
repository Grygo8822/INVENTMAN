using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Equipment.Interfaces
{
    public interface IEquipmentSearchUseCase
    {
        Task<IEnumerable<Item>> ExecuteAsync(string name = "");
    }
}