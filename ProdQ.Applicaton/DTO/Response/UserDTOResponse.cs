using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.DTO.Response
{
    public class UserDTOResponse
    {
        public int Id { get; set; }
        public string Role { get; set; } = null!;
        public string? Fullname { get; set; }        

        public DateOnly? Createddate { get; set; }

        public int? Createdby { get; set; }

        public string Summary { get; set; } = null!; //Summary of Createdate, Created By        
    }
}
