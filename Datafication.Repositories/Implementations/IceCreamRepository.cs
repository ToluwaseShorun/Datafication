using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datafication.Models.Dtos;
using Datafication.Models.InputModels;
using Datafication.Repositories.Contexts;
using Datafication.Repositories.Entities;
using Datafication.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace Datafication.Repositories.Implementations
{
    
    public class IceCreamRepository : IIceCreamRepository
    {

        
        private IceCreamDbContext context;


        public IceCreamRepository(IceCreamDbContext context)
        {
            this.context = context;
        }
        
        public async Task AddIceCreamToCategory(int iceCreamId, int categoryId)
        {
            using (var context = new IceCreamDbContext())
            {

                var OneIceCream = context
                .IceCreams
                .Find(iceCreamId);

                var oneCategory = context
                    .Categories
                    .Find(categoryId);



                context.IceCreams.Add(OneIceCream);
                context.SaveChanges();
            }


        }

        public async Task<int> CreateNewIceCream(IceCreamInputModel iceCream)
        {
            //var Response = new HttpResponseMessage(HttpStatusCode.Created);
            //Response.Headers.location = "hello";

            var newIceCream = new IceCream()
            {
                Name = iceCream.Name,
                Description = iceCream.Description,
                ManufacturerId = (int)iceCream.ManufacturerId
            };

            context.IceCreams.Add(newIceCream);
            await context.SaveChangesAsync();

            
            return newIceCream.Id;
            
        }

        public async void DeleteIceCream(int id)
        {
            
            var oneIceCream = context
                .IceCreams
                .Find(id);

            context.IceCreams.Remove(oneIceCream);
            context.SaveChanges();
        }

        public async Task<IEnumerable<IceCreamDto>> GetIceCreamsByCategoryId(int id) 
        {
            

            var allIceCreams = await context.Set<IceCreamDto>().AsQueryable().AsNoTracking().ToListAsync();
                
            return allIceCreams;
        }

        public async Task <IEnumerable<IceCreamDto>> GetAllIceCreams()
        {
            
            var allIceCreams = context
                .IceCreams
                // Added to simplify relational fixup because 
                // this is a read - only access to the database
                .AsNoTracking()
                .Select(I => new IceCreamDto
                {
                    Id = I.Id,
                    Name = I.Name,
                    Description = I.Description

                });
            return allIceCreams;

        }

        public async Task<IceCreamDetailsDto> GetIceCreamById(int id)
        {
            
            var oneIceCream = context
                .IceCreams
                // Added to simplify relational fixup because 
                // this is a read - only access to the database
                .AsNoTracking()
                .FirstOrDefault(I =>  I.Id == id);

                //.Select(I => new IceCreamDetailsDto
                //{
                //    Id = I.Id,
                //    Name = I.Name,
                //    Description = I.Description
                //}).ElementAtOrDefault(0);

            return new IceCreamDetailsDto
            {
                Id = oneIceCream.Id,
                Name = oneIceCream.Name,
                Description = oneIceCream.Description
            };

        }

        public async Task UpdateIceCream(int id, IceCreamInputModel iceCream)
        {

            var oneIceCream = context
                .IceCreams
                .Find(id);

            oneIceCream.Name = iceCream.Name;
            oneIceCream.Description = iceCream.Description;
            oneIceCream.ManufacturerId = iceCream.ManufacturerId;
            context.SaveChanges();

        }

        
    }
}