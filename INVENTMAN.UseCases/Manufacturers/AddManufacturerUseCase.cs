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
    public class AddManufacturerUseCase : IAddManufacturerUseCase
    {

        private readonly IManufacturersRepository manufacturersRepository;

        public AddManufacturerUseCase(IManufacturersRepository manufacturersRepository)
        {
            this.manufacturersRepository=manufacturersRepository;
        }

        public async Task ExecuteAsync(Manufacturer manufacturer)
        {
            await this.manufacturersRepository.AddManufacturerAsync(manufacturer);
        }

    }
}
