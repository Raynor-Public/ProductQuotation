using Asp.Versioning;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdQ.Domain.Abstraction.UnitOfWork;
using ProdQ.Applicaton.CQRS.Client.Queries;
using ProdQ.Applicaton.DTO.Response;
using ProdQ.Domain.Entities;
using ProdQ.Infrastructure.UnitOfWork;

namespace ProdQ.API.Controllers
{
    [ApiController]
    [ApiVersion(1)]
    //[Route("[controller]")] //If you want to manually input the version on the text box    
    [Route(template: "api/v{version:apiVersion}/[controller]")] //The version is specified on the link, no manual input of version.
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public readonly IUnitOfWork _unitOfWork;
        public ClientController(IMediator mediatr, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mediator = mediatr;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var response = await _mediator.Send(new GetClient());
            //return Ok(response);
            var a = _unitOfWork.ProductRepository.GetAll();
            return Ok(a);
        }

    }
}
