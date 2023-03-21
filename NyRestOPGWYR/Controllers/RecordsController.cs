using Microsoft.AspNetCore.Mvc;
using NyRestOPGWYR.Models;
using NyRestOPGWYR.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NyRestOPGWYR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private RecordRepository _recordRepository;

        public RecordsController(RecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }

        // GET: api/<RecordController>
        [HttpGet]
        public IEnumerable<Record> Get([FromQuery] string title, [FromQuery] string sortBy)
        {
            return _recordRepository.GetAll(title, sortBy);
        }

        // GET api/<RecordController>/5
        [HttpGet("{id}")]
        public Record? Get(int id)
        {
            return _recordRepository.GetById(id);
        }

        // POST api/<RecordController>
        [HttpPost]
        public Record Post([FromBody] Record value)
        {
            return _recordRepository.Add(value);
        }

        // PUT api/<RecordController>/5
        [HttpPut("{id}")]
        public Record? Put(int id, [FromBody] Record value)
        {
            return _recordRepository.Update(id, value);
        }

        // DELETE api/<RecordController>/5
        [HttpDelete("{id}")]
        public Record? Delete(int id)
        {
            return _recordRepository.Delete(id);
        }
    }
}
