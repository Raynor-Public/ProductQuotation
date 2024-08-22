using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.DTO.Request
{
    public class QouteDTORequest
    {        
        public string Subject { get; set; } = null!;

        public DateOnly? ValidUntil { get; set; }

        public decimal? TotalPrice { get; set; }        
    }
}
