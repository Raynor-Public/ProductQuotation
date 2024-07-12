using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProdQ.API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [ApiVersion(2)]
    [Route("api/v{version:apiVersion}/[controller]")]
    //[ApiVersion("2.0")]
    public class ProdQV2Controller : ControllerBase
    {
        // GET: api/<ProdQV2Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "V2 value01", "V2 value 2" };
        }

        // GET api/<ProdQV2Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProdQV2Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProdQV2Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProdQV2Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
