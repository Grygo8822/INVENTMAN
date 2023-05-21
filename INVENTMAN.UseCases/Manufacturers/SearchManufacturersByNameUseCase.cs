using INVENTMAN.Entities;
using INVENTMAN.UseCases.Equipment.Interfaces;
using INVENTMAN.UseCases.Manufacturers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTMAN.UseCases.Manufacturers
{
    public class SearchManufacturersByNameUseCase : ISearchManufacturersByNameUseCase
    {
        private readonly IManufacturersRepository manufacturersRepository;

        public SearchManufacturersByNameUseCase(IManufacturersRepository manufacturersRepository)
        {
            this.manufacturersRepository=manufacturersRepository;
        }

        public async Task<IEnumerable<Manufacturer>> ExecuteAsync(string name = "")
        {
            return await manufacturersRepository.GetManufacturerByNameAsync(name);
        }
    }
}
