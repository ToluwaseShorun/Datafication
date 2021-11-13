using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Datafication.Models.Dtos;
using Datafication.Models.InputModels;

namespace Datafication.Services.Interfaces
{
    public interface ICategoryService
    {
         Task<IEnumerable<IceCreamDto>> GetIceCreamsByCategoryId(int id);
         Task<string> CreateNewCategory(CategoryInputModel category);
         void DeleteCategory(int id);
    }
}