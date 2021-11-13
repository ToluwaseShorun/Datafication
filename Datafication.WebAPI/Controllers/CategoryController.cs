using Datafication.Models.InputModels;
using Datafication.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Datafication.Models.Dtos;
using Datafication.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Datafication.WebAPI.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IceCreamDbContext _context;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet("{id}")]        
        public async Task<IActionResult> GetIceCreamsByCategoryId(int id)
        {
            var response = await _categoryService.GetIceCreamsByCategoryId(id);
            
           if(response != null)
            {
                return Ok(response);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewCategory([FromBody] CategoryInputModel category)
        {
          var res =  await _categoryService.CreateNewCategory(category);
            if(res == "ok")
            {
                return Ok("success");
            }
            return BadRequest(res);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.DeleteCategory(id);
            return NoContent();
        }
    }
}