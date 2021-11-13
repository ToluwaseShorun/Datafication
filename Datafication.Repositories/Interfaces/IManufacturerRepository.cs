using Datafication.Models.Dtos;
using System.Threading.Tasks;

namespace Datafication.Repositories.Interfaces
{
    public interface IManufacturerRepository
    {
        Task <ManufacturerDetailsDto> GetManufacturerById(int id);
    }
}