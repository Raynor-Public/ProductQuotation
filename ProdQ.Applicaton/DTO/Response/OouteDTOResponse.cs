using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.DTO.Response
{
    public class OouteDTOResponse
    {
        public string Subject { get; set; } = null!;

        public string Summary { get; set; } = null!; //combination of Created Date, Valid untill, Total Price.
    }
}
