using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TobetoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        IInstructorService _instructorSevice;
        public InstructorsController(IInstructorService instructorSevice)
        {
            _instructorSevice = instructorSevice;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateInstructorRequest instructor)
        {
            await _instructorSevice.Add(instructor);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _instructorSevice.GetListAsync();
            return Ok(result);
        }
    }
}
