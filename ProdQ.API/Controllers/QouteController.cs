using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProdQ.API.Controllers
{
    [ApiController]
    [ApiVersion(1)]
    //[Route("[controller]")] //If you want to manually input the version on the text box    
    [Route(template: "api/v{version:apiVersion}/[controller]")] //The version is specified on the link, no manual input of version.
    public class QouteController : ControllerBase
    {
        // GET: api/<QouteController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<QouteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<QouteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<QouteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QouteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
