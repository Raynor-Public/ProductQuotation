using ProdQ.Domain.Abstraction.Repository;
using ProdQ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Infrastructure.Repositories
{
    public class ClientsRepo : IClientRepo
    {
        List<Client> clients = new List<Client>
        {
            new Client
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Password = "password123",
                Username = "johndoe",
                Street = "123 Main St",
                City = "Anytown",
                State = "Anystate",
                Country = "Anycountry",
                Created = DateTime.Now,
                Status = true
            },
            new Client
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                Password = "password456",
                Username = "janesmith",
                Street = "456 Elm St",
                City = "Othertown",
                State = "Otherstate",
                Country = "Othercountry",
                Created = DateTime.Now,
                Status = true
            },
            new Client
            {
                Id = 3,
                FirstName = "Bob",
                LastName = "Johnson",
                Email = "bob.johnson@example.com",
                Password = "password789",
                Username = "bobjohnson",
                Street = "789 Oak St",
                City = "Sometown",
                State = "Somestate",
                Country = "Somecountry",
                Created = DateTime.Now,
                Status = true
            }
        };

        public ClientsRepo() { 
        
        }

        public Task<List<Client>> GetAllClients()
        {
            return Task.FromResult(clients);            
        }

        public Task<List<Client>> GetClientsById()
        {
            throw new NotImplementedException();
        }
    }
}
