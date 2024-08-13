using ProdQ.Domain.Abstraction.Repository;
using ProdQ.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Infrastructure.Repositories
{
    public class QouteItemRepository : BaseRepository<QouteItem>, IQouteItemRepository
    {
        public QouteItemRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
