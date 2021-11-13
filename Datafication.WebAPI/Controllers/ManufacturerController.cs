using Datafication.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Datafication.WebAPI.Controllers
{
    [ApiController]
    [Route("api/manufacturers")]

    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _manufacturerService;

        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        [HttpGet]
        [Route("{manufacturerId}")]
        public async Task <IActionResult> GetManufacturerById(int manufacturerId) 
            => Ok(_manufacturerService.GetManufacturerById(manufacturerId));
    }
}