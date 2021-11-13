using Datafication.Models.Dtos;
using Datafication.Models.InputModels;
using Datafication.Repositories.Contexts;
using Datafication.Repositories.Entities;
using Datafication.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Datafication.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
        
    {
        private IceCreamDbContext context;
        private IceCreamRepository _categoryRepository;

        public CategoryRepository(IceCreamDbContext context)
        {
            this.context = context;
        }
        public async Task<int> CreateNewCategory(CategoryInputModel category)
        {
        
            var newCategory = new Category()
            {
                Name = category.Name,
                ParentCategoryId = (int)category.ParentCategoryId
            };
            context.Categories.Add(newCategory);
            await context.SaveChangesAsync();

            return newCategory.Id;

            
        }

        public void DeleteCategory(int id)
        {
            using var dbContext = new IceCreamDbContext();

            var oneCategory = dbContext
                .Categories
                .Find(id);

            dbContext.Categories.Remove(oneCategory);
            dbContext.SaveChanges();
        }

        public async Task<IceCreamDto> GetIceCreamsByCategoryId(int id)
        {

            var oneIceCream = context
                .Categories
                // Added to simplify relational fixup because 
                // this is a read - only access to the database
                .AsNoTracking()
                .FirstOrDefault(I => I.Id == id);

            //.Select(I => new IceCreamDetailsDto
            //{
            //    Id = I.Id,
            //    Name = I.Name,
            //    Description = I.Description
            //}).ElementAtOrDefault(0);

            return new IceCreamDto
            {
                Id = oneIceCream.Id,
                Name = oneIceCream.Name,
                
            };
        }
    }
}