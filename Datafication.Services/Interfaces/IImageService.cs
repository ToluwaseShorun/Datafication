using System.Collections.Generic;
using System.Threading.Tasks;
using Datafication.Models.Dtos;
using Datafication.Models.InputModels;

namespace Datafication.Services.Interfaces
{
    public interface IImageService
    {
         Task<ImageDetailsDto> GetImageById(int id);
         Task <IEnumerable<ImageDto>> GetAllImagesByIceCreamId(int iceCreamId);
         Task<string> CreateNewImage(ImageInputModel image);
    }
}