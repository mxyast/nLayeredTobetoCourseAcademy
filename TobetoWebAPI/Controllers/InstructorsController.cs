using Business.Abstracts;
using Business.Dtos.Requests.InstructorRequest;
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

        [HttpDelete]
        public async Task<IActionResult> Delet([FromBody] DeleteInstructorRequest deleteInstructorRequest)
        {
            var result = await _instructorSevice.Delete(deleteInstructorRequest);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateInstructorRequest updateInstructorRequest)
        {
            var result = await _instructorSevice.Update(updateInstructorRequest);
            return Ok(result);
        }
    }
}
