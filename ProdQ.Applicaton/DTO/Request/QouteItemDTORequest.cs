using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.DTO.Request
{
    public class QouteItemDTORequest
    {       

        public int QouteId { get; set; }

        public int ProductId { get; set; }

        public int? Quantity { get; set; }

    }
}
