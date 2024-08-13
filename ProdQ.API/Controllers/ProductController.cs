using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using ProdQ.Infrastructure;
using ProdQ.Infrastructure.UnitOfWork;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProdQ.API.Controllers
{
    
    [ApiController]
    [ApiVersion(1)]
    [Route(template: "api/v{version:apiVersion}/[controller]")] //The version is specified on the link, no manual input of version.
    public class ProductController : ControllerBase
    {
        //public readonly UnitOfWork _unitOfWork;
        //public ProductController(UnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}

        public ProductController()
        {
            
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok("Test...");
            //return Ok(_unitOfWork.ProductRepository.GetAll());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
