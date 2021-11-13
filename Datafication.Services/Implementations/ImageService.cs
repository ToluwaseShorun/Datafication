using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Datafication.Models.Dtos;
using Datafication.Models.InputModels;
using Datafication.Repositories.Interfaces;
using Datafication.Services.Interfaces;

namespace Datafication.Services.Implementations
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task<string> CreateNewImage(ImageInputModel image)
        {
            try
            {
                await _imageRepository.CreateNewImage(image);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
            

        public async Task<IEnumerable<ImageDto>> GetAllImagesByIceCreamId(int iceCreamId)
        {
            try
            {
                var x = await _imageRepository.GetAllImagesByIceCreamId(iceCreamId);


                return x;

            }
            catch (Exception ex)
            {
                //log exception
                return null;
            }

            
        }
            

        public async Task <ImageDetailsDto> GetImageById(int id)
        {
            try
            {
                var x = await _imageRepository.GetImageById(id);
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