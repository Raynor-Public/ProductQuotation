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
        public int Id { get; set; }
        public int QouteId { get; set; }

        public int ProductId { get; set; }

        public int? Quantity { get; set; }

        //public List<QouteDTOResponse> DetailData { get; set; } = new List<QouteDTOResponse>();        
    }
}
