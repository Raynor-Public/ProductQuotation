using ProdQ.Applicaton.Abstraction;
using ProdQ.Applicaton.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdQ.Domain.Abstraction.Repository;
using ProdQ.Domain.Entities;

namespace ProdQ.Applicaton.CQRS.Client.Queries
{
    public record GetClientHandler : IQueryHandler<GetClient, List<ClientDTOResponse>>
    {
        private readonly IClientRepo _clientRepo;
        public GetClientHandler(IClientRepo clientRepo) { 
            _clientRepo = clientRepo;         
        }
        public Task<List<ClientDTOResponse>> Handle(GetClient request, CancellationToken cancellationToken)
        {
            //var response = new List<ClientDTOResponse>();
            var response = _clientRepo.GetAllClients();
            throw new NotImplementedException();
        }
    }
}
