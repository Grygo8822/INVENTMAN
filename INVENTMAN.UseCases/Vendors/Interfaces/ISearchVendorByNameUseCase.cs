using INVENTMAN.Entities;

namespace INVENTMAN.UseCases.Vendors.Interfaces
{
    public interface ISearchVendorByNameUseCase
    {
        Task<IEnumerable<Vendor>> ExecuteAsync(string name = "");
    }
}