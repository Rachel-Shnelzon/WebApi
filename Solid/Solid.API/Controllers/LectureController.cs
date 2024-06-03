using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectureController : ControllerBase
    {
        private readonly ILectureService _LectureService;
        public LectureController(ILectureService lectureService)
        {
            _LectureService = lectureService;
        }

        // GET: api/<LectureController>
        [HttpGet]
        public ActionResult<Lecture> Get()
        {
            return Ok(_LectureService.Get());
        }

        // GET api/<LectureController>/5
        [HttpGet("{id}")]
        public ActionResult<Lecture> Get(int id)
        {
            return Ok(_LectureService.Get(id));
        }

        // POST api/<LectureController>
        [HttpPost]
        public void Post([FromBody] Lecture value)
        {
            _LectureService.Post(value);
        }

        // PUT api/<LectureController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Lecture value)
        {
            _LectureService.Put(id, value);
        }

        // DELETE api/<LectureController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _LectureService.Delete(id);
        }
    }
}
