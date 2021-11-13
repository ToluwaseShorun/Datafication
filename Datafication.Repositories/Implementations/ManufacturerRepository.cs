using System.Linq;
using System.Threading.Tasks;
using Datafication.Models.Dtos;
using Datafication.Repositories.Contexts;
using Datafication.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Datafication.Repositories.Implementations
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private IceCreamDbContext context;

        public ManufacturerRepository(IceCreamDbContext context)
        {
            this.context = context;
        }
        public async Task< ManufacturerDetailsDto> GetManufacturerById(int id)
        {

            var ManufacturerById = context
                .Manufacturers
                .Where(m => m.Id == id)
                .Select(m => new ManufacturerDetailsDto
                {
                    Id = m.Id,
                    Name = m.Name,
                    ExternalUrl = m.ExternalUrl,
                    Bio = m.Bio
                }).ElementAtOrDefault(0);
            return ManufacturerById;
        }
    }
}