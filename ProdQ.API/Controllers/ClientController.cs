﻿using Asp.Versioning;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdQ.Applicaton.CQRS.Client.Queries;
using ProdQ.Applicaton.DTO.Response;

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
        public ClientController(IMediator mediatr, IMapper mapper ) { 
            _mediator = mediatr;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<ClientDTOResponse>>GetClients(GetClient request)
        {
            var clients = _mediator.Send(request);
            var mappedResult = _mapper.Map<List<ClientDTOResponse>>(clients);
            return await mappedResult;
        }
    }
}
