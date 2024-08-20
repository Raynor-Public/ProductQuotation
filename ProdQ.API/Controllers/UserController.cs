using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProdQ.Applicaton.CQRS.UserCQ.Commands;
using ProdQ.Applicaton.CQRS.UserCQ.Queries;
using ProdQ.Domain.Abstraction.UnitOfWork;
using ProdQ.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProdQ.API.Controllers
{
    [ApiController]
    [ApiVersion(1)]    
    [Route(template: "api/v{version:apiVersion}/[controller]")] //The version is specified on the link, no manual input of version.
    public class UserController : ControllerBase
    {
        //private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {            
            _mediator = mediator;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var request = new GetAllUsersQuery();            
            return Ok(await _mediator.Send(request));            
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {            
            var req = new GetUserByIdQuery(id);            
            return Ok(await _mediator.Send(req));
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult>AddUser([FromBody] CreateUserCammand request)
        {
            var req = await _mediator.Send(request);
            return Ok(req);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
