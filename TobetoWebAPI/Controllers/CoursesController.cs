using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TobetoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseSevice _courseSevice;
        public CoursesController(ICourseSevice courseSevice)
        {
            _courseSevice = courseSevice;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest course)
        {
            await _courseSevice.Add(course);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseSevice.GetListAsync();
            return Ok(result);
        }
    }
}
