using Datafication.Models.InputModels;
using Datafication.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Datafication.WebAPI.Controllers
{
    [ApiController]
    [Route("api/icecreams")]
    public class IceCreamController : ControllerBase
    {
        private readonly IIceCreamService _iceCreamService;
        private readonly IImageService _imageService;

        public IceCreamController(IIceCreamService iceCreamService, IImageService imageService)
        {
            _iceCreamService = iceCreamService;
            _imageService = imageService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAllIceCreams()
            => Ok(_iceCreamService.GetAllIceCreams());
        
        [HttpGet]
        [Route("{iceCreamId}", Name = "GetIceCreamById")]
        public async  Task<IActionResult> GetIceCreamById(int iceCreamId)
        {
            var res = await _iceCreamService.GetIceCreamById(iceCreamId);
            if (res == null)
            {
                return Ok("success");
            }
            return BadRequest(res);

        }
            

        [HttpGet]
        [Route("{iceCreamId}/images")]
        public IActionResult GetAllImagesByIceCreamId(int iceCreamId)
            => Ok(_imageService.GetAllImagesByIceCreamId(iceCreamId));

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateNewIceCream([FromBody] IceCreamInputModel iceCream)
        {
            var res = await _iceCreamService.CreateNewIceCream(iceCream);
            if (res == "ok")
            {
                return Ok("success");
            }
            return BadRequest(res);
        }

        [HttpPut]
        [Route("{iceCreamId}")]
        public async Task<IActionResult> UpdateIceCream(int iceCreamId, [FromBody] IceCreamInputModel iceCream)
        {
            var res = await _iceCreamService.UpdateIceCream(iceCreamId, iceCream);
            if (res == "ok")
            {
                return Ok("success");
            }
            return BadRequest(res);
        }

        [HttpDelete]
        [Route("{iceCreamId}")]
        public async Task<IActionResult> DeleteIceCream(int iceCreamId)
        {
            _iceCreamService.DeleteIceCream(iceCreamId);
            return NoContent();
        }

        [HttpPatch]
        [Route("{iceCreamId}/categories/{categoryId}")]
        public async Task<IActionResult> AddIceCreamToCategory(int iceCreamId, int categoryId)
        {

            try
            {
               var toti =  await _iceCreamService.AddIceCreamToCategory(iceCreamId, categoryId);
                if (toti == "ok")
                {
                    return Ok("success");
                }
                return BadRequest(toti);
                

            }
            catch (Exception ex)
            {
                //log exception
                return null;
            }
           
        }
    }
}
