using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.DTO.Response
{
    public class QouteItemDTOResponse
    {
        //To discussed..
        public int QouteId { get; set; }

        public int ProductId { get; set; }

        public int? Quantity { get; set; }

        public List<OouteDTOResponse> DetailData { get; set; } = new List<OouteDTOResponse>();
    }
}
