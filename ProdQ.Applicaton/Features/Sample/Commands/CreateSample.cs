using ProdQ.Applicaton.Abstraction;
using ProdQ.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace ProdQ.Applicaton.Features.Sample.Commands
{
    public record CreateSample() : ICommand<List<User>>
    {
    }
}
