using ProdQ.Applicaton.Abstraction;
using ProdQ.Applicaton.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdQ.Domain.Entities;
using ProdQ.Infrastructure.Data.Models;

namespace ProdQ.Applicaton.CQRS.Client.Queries
{
    public record GetClient(): IQuery<List<ClientDTOResponse>>
    {
    }
}
