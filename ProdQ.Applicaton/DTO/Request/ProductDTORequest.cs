using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.DTO.Request
{
    public class ProductDTORequest
    {
        public string Code { get; set; } = null!;
        public string? Description { get; set; } 
        public decimal? Price { get; set; }
    }
}
