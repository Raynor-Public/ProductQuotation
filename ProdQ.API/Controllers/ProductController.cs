using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProdQ.Applicaton.CQRS.ProductCQ.Queries;
using ProdQ.Domain.Abstraction.UnitOfWork;
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
        IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }        

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {            
            var request = new GetAllProductQuery();
            return Ok(await _mediator.Send(request));
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok("");
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Product request)
        {
            //var result = await _unitOfWork.ProductRepository.AddAsync(request);
            return Ok("");
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
