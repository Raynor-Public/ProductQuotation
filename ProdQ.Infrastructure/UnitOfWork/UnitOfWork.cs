using ProdQ.Domain.Abstraction.Repository;
using ProdQ.Domain.Abstraction.UnitOfWork;

using ProdQ.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //public readonly ApplicationDbContext _context;       


        //public UnitOfWork(ApplicationDbContext context) 
        //{
        //    _context = context;            
        //    ProductRepository = new ProductRepository(_context);
        //    UserRepository = new UserRepository(_context);
        //    QouteRepository = new QouteRepository(_context);
        //    QouteItemRepository = new QouteItemRepository(_context);

        //    //Product = new ProductRepository(_context);
        //    //User = new UserRepository(context);
        //    //Qoute = new QouteRepository(_context);
        //    //QouteItem = new QouteItemRepository(_context);
        //}

        //public IProductRepository ProductRepository { get; set; }
        //public IUserRepository UserRepository { get; set; }
        //public IQouteRepository QouteRepository { get; set; }
        //public IQouteItemRepository QouteItemRepository { get; set; }

        ////public IProductRepository ProductRepository => throw new NotImplementedException();

        ////public IUserRepository UserRepository => throw new NotImplementedException();

        ////public IQouteRepository QouteRepository => throw new NotImplementedException();

        ////public IQouteItemRepository QouteItemRepository => throw new NotImplementedException();

        //public void Dispose()
        //{
        //    _context.Dispose();
        //}

        public int Save()
        {
            return 0;
            //return _context.SaveChanges();
        }
    }
}
