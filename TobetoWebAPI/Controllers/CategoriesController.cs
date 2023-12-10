using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TobetoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoriesController(ICategoryService productService)
        {
            _categoryService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCategoryRequest category)
        {
            await _categoryService.Add(category);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _categoryService.GetListAsync();
            return Ok(result);
        }
    }
}
