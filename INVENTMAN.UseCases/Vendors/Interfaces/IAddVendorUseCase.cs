using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Vendors.Interfaces
{
    public interface IAddVendorUseCase
    {
        Task ExecuteAsync(Vendor vendor);
    }
}