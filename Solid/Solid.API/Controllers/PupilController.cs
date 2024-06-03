using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PupilController : ControllerBase
    {
        private readonly IPupilService _PupilService;
        public PupilController(IPupilService pupilService)
        {
            _PupilService = pupilService;
        }

        // GET: api/<PupilController>
        [HttpGet]
        public ActionResult<Pupil> Get()
        {
            return Ok(_PupilService.Get());
        }

        // GET api/<PupilController>/5
        [HttpGet("{id}")]
        public ActionResult<Pupil> Get(int id)
        {
            return Ok(_PupilService.Get(id));
        }

        // POST api/<PupilController>
        [HttpPost]
        public void Post([FromBody] Pupil value)
        {
            _PupilService.Post(value);
        }

        // PUT api/<PupilController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pupil value)
        {
            _PupilService.Put(id, value);
        }

        // DELETE api/<PupilController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _PupilService.Delete(id);
        }
    }
}
