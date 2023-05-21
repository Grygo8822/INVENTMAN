using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Manufacturers.Interfaces
{
    public interface ISearchManufacturersByNameUseCase
    {
        Task<IEnumerable<Manufacturer>> ExecuteAsync(string name = "");
    }
}