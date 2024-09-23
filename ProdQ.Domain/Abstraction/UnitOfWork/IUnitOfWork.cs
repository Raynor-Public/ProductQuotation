using ProdQ.Domain.Abstraction.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Domain.Abstraction.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        //IProductRepository ProductRepository { get; }
        //IUserRepository UserRepository { get; }
        //IQouteRepository QouteRepository { get; }
        //IQouteItemRepository QouteItemRepository { get; }
        int Save();
        
    }
}
