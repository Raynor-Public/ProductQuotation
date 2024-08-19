﻿using ProdQ.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Domain.Abstraction.Repository
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        string CustomFnc();
    }
}
