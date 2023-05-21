using INVENTMAN.Entities;
using INVENTMAN.UseCases.Manufacturers.Interfaces;
using INVENTMAN.UseCases.Vendors.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Vendors
{
    public class SearchVendorByNameUseCase : ISearchVendorByNameUseCase
    {
        private readonly IVendorRepository vendorRepository;

        public SearchVendorByNameUseCase(IVendorRepository vendorRepository)
        {
            this.vendorRepository=vendorRepository;
        }

        public async Task<IEnumerable<Vendor>> ExecuteAsync(string name = "")
        {
            return await vendorRepository.GetVendorByNameAsync(name);
        }
    }
}
