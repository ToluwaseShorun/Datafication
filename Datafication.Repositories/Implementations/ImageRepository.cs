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
    public class ImageRepository : IImageRepository
    {
        private IceCreamDbContext context;

        public ImageRepository(IceCreamDbContext context)
        {
            this.context = context;
        }

        public async Task <int> CreateNewImage(ImageInputModel image)
        {
            

            var newImage = new Image
            {
                Url = image.Url,
                IceCreamId = image.IceCreamId
            };
            context.Images.Add(newImage);
            context.SaveChanges();
            return newImage.Id;
        }

        public async Task<IEnumerable<ImageDto>> GetAllImagesByIceCreamId(int iceCreamId)
        {
            

            var allImagesByIceCreamId = context
                .Images
                .Where(I => I.IceCreamId == iceCreamId)
                .Select(I => new ImageDto
                {
                    Id = I.Id,
                    Url = I.Url
                });

            return allImagesByIceCreamId;

            
        }

        public async Task<ImageDetailsDto> GetImageById(int id)
        {
            

            var OneImageById = context
                .Images
                .Where(I => I.Id == id)
                .Select(I => new ImageDetailsDto
                {
                    Id = I.Id,
                }).ElementAtOrDefault(0);

            return OneImageById;
        }
    }
}