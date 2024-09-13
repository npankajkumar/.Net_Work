using Microsoft.AspNetCore.Mvc;
using MVCRestAPIDemos.Models;
using MVCRestAPIDemos.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCRestAPIDemos.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        private readonly IStoreListRepository _repo;
        public StoresController(IStoreListRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<StoresController>
        [HttpGet]
        public IEnumerable<Store> Get()
        {
            return _repo.GetAll();
        }

        [HttpGet("location/{location}")]
        public string GetByStores(string location)
        {
            return "location";
        }

        // GET api/<StoresController>/5
        [HttpGet("{id}")]
        public string GetById(int id)
        {
            return "id";
        }
        

        // POST api/<StoresController>
        [HttpPost]
        public void Post([FromBody] Store value)
        {
            _repo.Add(value);
        }

        // PUT api/<StoresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Store value)
        {
            _repo.Update(id,value);
        }

        // DELETE api/<StoresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.Delete(id);

        }
    }


}
