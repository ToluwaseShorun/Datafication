using System.Collections.Generic;
using System.Threading.Tasks;
using Datafication.Models.Dtos;
using Datafication.Models.InputModels;

namespace Datafication.Services.Interfaces
{
    public interface IIceCreamService
    {
        //done
        Task <IEnumerable<IceCreamDto>> GetAllIceCreams();
        //done
        Task <IceCreamDetailsDto> GetIceCreamById(int id);
        //done
        Task<string> CreateNewIceCream(IceCreamInputModel iceCream);
        //Done
        Task <string> UpdateIceCream(int id, IceCreamInputModel iceCream);
        //done
        void DeleteIceCream(int id);
        Task<string> AddIceCreamToCategory(int iceCreamId, int categoryId);
    }
}