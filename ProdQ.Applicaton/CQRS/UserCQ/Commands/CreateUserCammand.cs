using ProdQ.Applicaton.Abstraction;
using ProdQ.Applicaton.DTO.Request;
using ProdQ.Applicaton.DTO.Response;
using ProdQ.Applicaton.DTO.Response.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.CQRS.UserCQ.Commands
{
    public sealed record CreateUserCammand(ClientDTORequest reqParams) : ICommand<Response<ClientDTOResponse>>;   
    
}
