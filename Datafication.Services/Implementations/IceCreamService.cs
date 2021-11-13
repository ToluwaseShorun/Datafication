using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Datafication.Models.Dtos;
using Datafication.Models.InputModels;
using Datafication.Repositories.Interfaces;
using Datafication.Services.Interfaces;

namespace Datafication.Services.Implementations
{
    public class IceCreamService : IIceCreamService
    {
        private readonly IIceCreamRepository _iceCreamRepository;



        public IceCreamService(IIceCreamRepository iceCreamRepository )
        {
            this._iceCreamRepository = iceCreamRepository;
        }

        public async Task<string> AddIceCreamToCategory(int iceCreamId, int categoryId)
        {

            try
            {
                await _iceCreamRepository.AddIceCreamToCategory(iceCreamId, categoryId);

                return "Ok";

            }
            catch (Exception ex)
            {
                //log exception
                return null;
            }
        }
            
        

        public async Task<string> CreateNewIceCream(IceCreamInputModel iceCream)
        {
            try
            {
                await _iceCreamRepository.CreateNewIceCream(iceCream);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }


        public async void DeleteIceCream(int id)
        {
             _iceCreamRepository.DeleteIceCream(id);
        }
            

        public async Task <IEnumerable<IceCreamDto>> GetAllIceCreams()
        {
            try
            {
                var x = await _iceCreamRepository.GetAllIceCreams();


                return x;

            }
            catch (Exception ex)
            {
                //log exception
                return null;
            }
           
        }
        

        public async Task<IceCreamDetailsDto> GetIceCreamById(int id)
        {
            try
            {
                var x = await _iceCreamRepository.GetIceCreamById(id);

                return x;

            }
            catch (Exception ex)
            {
                //log exception
                return null;
            }
        }


      
        public async Task<string> UpdateIceCream(int id, IceCreamInputModel iceCream)
        {
            try
            {
                await _iceCreamRepository.UpdateIceCream(id, iceCream);
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        
    }
}