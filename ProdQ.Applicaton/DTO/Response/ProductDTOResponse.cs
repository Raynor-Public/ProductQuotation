using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.DTO.Response
{
    public class ProductDTOResponse
    {
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? Summary { get; set; } //Combine the description, price, created date, created by
    }
}
