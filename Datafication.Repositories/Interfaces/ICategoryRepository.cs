using System.Collections.Generic;
using System.Threading.Tasks;
using Datafication.Models.Dtos;
using Datafication.Models.InputModels;

namespace Datafication.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
         Task<IceCreamDto> GetIceCreamsByCategoryId(int id);
         Task <int> CreateNewCategory(CategoryInputModel category);
         void DeleteCategory(int id);
    }
}