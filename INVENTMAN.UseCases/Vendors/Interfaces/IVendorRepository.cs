using INVENTMAN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Vendors.Interfaces
{
    public interface IVendorRepository
    {
        Task AddVendorAsync(Vendor vendor);

        Task<IEnumerable<Vendor>> GetVendorByNameAsync(string name);
    }
}
