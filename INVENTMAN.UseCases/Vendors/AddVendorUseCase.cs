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
    public class AddVendorUseCase : IAddVendorUseCase
    {
        private readonly IVendorRepository vendorRepository;

        public AddVendorUseCase(IVendorRepository vendorRepository)
        {
            this.vendorRepository=vendorRepository;
        }

        public async Task ExecuteAsync(Vendor vendor)
        {
            await this.vendorRepository.AddVendorAsync(vendor);
        }
    }
}
