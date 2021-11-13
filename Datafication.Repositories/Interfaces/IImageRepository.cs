using System.Collections.Generic;
using System.Threading.Tasks;
using Datafication.Models.Dtos;
using Datafication.Models.InputModels;

namespace Datafication.Repositories.Interfaces
{
    public interface IImageRepository
    {
        Task<ImageDetailsDto> GetImageById(int id);
        Task<IEnumerable<ImageDto>> GetAllImagesByIceCreamId(int iceCreamId);
        Task<int> CreateNewImage(ImageInputModel image);
    }
}