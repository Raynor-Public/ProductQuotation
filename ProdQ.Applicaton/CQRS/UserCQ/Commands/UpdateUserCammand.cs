using ProdQ.Applicaton.Abstraction;
using ProdQ.Applicaton.DTO.Request;
using ProdQ.Applicaton.DTO.Response;
using ProdQ.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.CQRS.UserCQ.Commands
{
    public sealed record UpdateUserCammand(int Id, ClientDTORequest reqParams) : ICommand<Response<ClientDTOResponse>>;    
}
