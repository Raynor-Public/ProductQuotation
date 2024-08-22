using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.DTO.Response
{
    public class QouteDTOResponse
    {
        public int Id { get; set; }

        public string Subject { get; set; } = null!;

        public DateOnly? ValidUntil { get; set; }

        public decimal? TotalPrice { get; set; }

        public DateOnly? Createddate { get; set; }

        public int? Createdby { get; set; }
    }
}
