using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProdQ.API.Controllers
{
    [ApiController]
    [ApiVersion(1)]
    //[Route("[controller]")] //If you want to manually input the version on the text box    
    [Route(template:"api/v{version:apiVersion}/[controller]")] //The version is specified on the link, no manual input of version.
    public class ProdQV1Controller : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProdQV1Controller(IMediator mediator) 
        { 
            _mediator = mediator;
        }

        // GET: api/<ProdQV1Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "V1 value01", "V1 value 2" };
        }                

        // GET api/<ProdQV1Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProdQV1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProdQV1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProdQV1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
