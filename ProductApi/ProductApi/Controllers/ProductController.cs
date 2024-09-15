using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using ProductApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private ProductController(IProductService obj) {
            _productService = obj;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetProducts();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public bool Post([FromBody] Product value)
        {
            return _productService.AddProduct(value);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product value)
        {
            if (_productService.UpdateProduct(id, value))
            {
                return Ok(value);
            }
            return BadRequest();
        }


        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
