using ProdQ.Applicaton.Abstraction;
using ProdQ.Domain.Abstraction.Repository;
using ProdQ.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.CQRS.Sample.Commands
{
    public record CreateSampleHandler : ICommandHander<CreateSample, List<User>>
    {
        List<User> users = new List<User> { 
            new User {Id = 1, FirstName = "Banski", LastName = "Ibon"},
            new User {Id = 2, FirstName = "Liam", LastName = "Wynn"},
            new User {Id = 2, FirstName = "Matthieu", LastName = "Rhye"}
        };

        private readonly ICreateSampleRepo _createSampleRepo;

        public CreateSampleHandler(ICreateSampleRepo createSampleRepo)
        {
            _createSampleRepo = createSampleRepo;
        }

        public Task<List<User>> Handle(CreateSample request, CancellationToken cancellationToken)
        {
            //try
            //{
            //    return Task.FromResult(users.ToList());
            //}
            //catch(Exception ex)
            //{
            //    throw new NotImplementedException();
            //}            

            return Task.FromResult(_createSampleRepo.GetSampleRepo(12));

            //return Task.FromResult(users.ToList());
        }
    }
}
