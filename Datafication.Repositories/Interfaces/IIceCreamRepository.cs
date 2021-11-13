using System.Collections.Generic;
using System.Threading.Tasks; 
using Datafication.Models.Dtos;
using Datafication.Models.InputModels;

namespace Datafication.Repositories.Interfaces
{
    public interface IIceCreamRepository
    {
        Task <IEnumerable<IceCreamDto>> GetAllIceCreams();
        Task <IceCreamDetailsDto> GetIceCreamById(int id);
        Task<int> CreateNewIceCream(IceCreamInputModel iceCream);
        Task UpdateIceCream(int id, IceCreamInputModel iceCream);
        void DeleteIceCream(int id);
        Task AddIceCreamToCategory(int iceCreamId, int categoryId);
        Task<IEnumerable<IceCreamDto>> GetIceCreamsByCategoryId(int id);
    }
}