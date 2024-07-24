using ProdQ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Domain.Abstraction.Repository
{
    public interface IClientRepo
    {
        Task<List<Client>> GetAllClients();
        Task<List<Client>> GetClientsById();
    }
}
