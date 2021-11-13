using Datafication.Models.Dtos;
using Datafication.Repositories.Interfaces;
using Datafication.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Datafication.Services.Implementations
{
    public class ManufacturerService : IManufacturerService
    {
        private readonly IManufacturerRepository _manufacturerRepository;

        public ManufacturerService(IManufacturerRepository manufacturerRepository)
        {
            _manufacturerRepository = manufacturerRepository;
        }

        public async Task <ManufacturerDetailsDto> GetManufacturerById(int id)
        {
            try
            {
               var x = await _manufacturerRepository.GetManufacturerById(id);

                return x;

            }
            catch (Exception ex)
            {
                //log exception
                return null;
            }
            
        }

      
    }
            
}