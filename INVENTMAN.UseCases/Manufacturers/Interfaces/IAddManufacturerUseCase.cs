using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Manufacturers.Interfaces
{
    public interface IAddManufacturerUseCase
    {
        Task ExecuteAsync(Manufacturer manufacturer);
    }
}