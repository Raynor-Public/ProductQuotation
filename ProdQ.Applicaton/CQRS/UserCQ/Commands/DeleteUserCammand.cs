using ProdQ.Applicaton.Abstraction;
using ProdQ.Applicaton.DTO.Response.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.CQRS.UserCQ.Commands
{
    public sealed record DeleteUserCammand(int Id) : ICommand<Response<string>>;    
}
