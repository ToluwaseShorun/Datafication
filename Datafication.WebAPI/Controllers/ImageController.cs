using Datafication.Models.InputModels;
using Datafication.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Datafication.WebAPI.Controllers
{
    [ApiController]
    [Route("api/images")]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet]
        [Route("{imageId}", Name = "GetImageById")]
        public async Task<IActionResult> GetImageById(int imageId)
        {
            var res = await _imageService.GetImageById(imageId);
            if (res == null)
            {
                return Ok("success");
            }
            return BadRequest(res);
        }
        [HttpPost]
        [Route("")]
        public async  Task<IActionResult> CreateNewImage([FromBody] ImageInputModel image) 
        {


            var res = await _imageService.CreateNewImage(image);
            if (res == "ok")
            {
                return Ok("success");
            }
            return BadRequest(res);
        }
    }
}