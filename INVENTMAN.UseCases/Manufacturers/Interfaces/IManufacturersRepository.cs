using INVENTMAN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Manufacturers.Interfaces
{
    public interface IManufacturersRepository
    {
       public Task AddManufacturerAsync(Manufacturer manufacturer);

       public Task<IEnumerable<Manufacturer>> GetManufacturerByNameAsync(string manufacturerName);
    }
}
