using Datafication.Models.Dtos;
using System.Threading.Tasks;

namespace Datafication.Services.Interfaces
{
    public interface IManufacturerService
    {
         Task <ManufacturerDetailsDto> GetManufacturerById(int id);
    }
}