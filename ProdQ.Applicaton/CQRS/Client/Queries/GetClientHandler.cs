using ProdQ.Applicaton.Abstraction;
using ProdQ.Applicaton.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdQ.Domain.Abstraction.Repository;
using ProdQ.Domain.Entities;
using AutoMapper;
using ProdQ.Domain.Shared;
using ProdQ.Infrastructure.Repositories;


namespace ProdQ.Applicaton.CQRS.Client.Queries
{
    public record GetClientHandler : IQueryHandler<GetClient, Response<List<ClientDTOResponse>>>
    {
        //private readonly IClientRepo _clientRepo;
        //private readonly IMapper _mapper;

        //public GetClientHandler(IClientRepo clientRepo, IMapper mapper) { 
        //    _clientRepo = clientRepo;
        //    _mapper = mapper;
        //}

        //public async Task<Response<List<ClientDTOResponse>>> Handle(GetClient request, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        var resultDTO = new Response<List<ClientDTOResponse>>();
        //        var repo = await _clientRepo.GetAllClients();
        //        resultDTO.Data = _mapper.Map<List<ClientDTOResponse>>(repo);
        //        return resultDTO;
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Response<List<ClientDTOResponse>>();
        //    }

        //}

        private readonly IMapper _mapper;

        public GetClientHandler(IMapper mapper)
        {            
            _mapper = mapper;
        }
        public async Task<Response<List<ClientDTOResponse>>> Handle(GetClient request, CancellationToken cancellationToken)
        {
            try
            {   
                return null;
            }
            catch (Exception ex)
            {
                return new Response<List<ClientDTOResponse>>();
            }
            
        }       

    }
}
