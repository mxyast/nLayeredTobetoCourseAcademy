using Business.Abstracts;
using Business.Dtos.Requests.CourseRequest;
using Microsoft.AspNetCore.Mvc;

namespace TobetoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseSevice _courseService;
        public CoursesController(ICourseSevice courseSevice)
        {
            _courseService = courseSevice;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseRequest course)
        {
            var result = await _courseService.Add(course);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _courseService.GetListAsync();
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteCourseRequest deleteCourseRequest)
        {
            var result = await _courseService.Delete(deleteCourseRequest);
            return Ok(result);
        }

        [HttpPut]

        public async Task<IActionResult> Update([FromBody] UpdateCourseRequest updateCourseRequest)
        {
            var result = await _courseService.Update(updateCourseRequest);
            return Ok(result);
        }
    }
}
