using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Datafication.Models.Dtos;
using Datafication.Models.InputModels;
using Datafication.Repositories.Interfaces;
using Datafication.Services.Interfaces;
using Datafication.Repositories.Contexts;
using System.Linq;

namespace Datafication.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IIceCreamRepository _iceCreamRepository;

        public CategoryService(ICategoryRepository categoryRepository, IIceCreamRepository iceCreamRepository)
        {
            this._categoryRepository = categoryRepository;
            this._iceCreamRepository = iceCreamRepository;
        }

        public async Task<string> CreateNewCategory(CategoryInputModel category)
        {
            try
            {
                await _categoryRepository.CreateNewCategory(category);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
           
        }

        public void DeleteCategory(int id)
        {
           _categoryRepository.DeleteCategory(id);
        }
             

        public async Task<IEnumerable<IceCreamDto>> GetIceCreamsByCategoryId(int id)
        {

            try
            {
               var x = await _iceCreamRepository.GetIceCreamsByCategoryId(id);

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