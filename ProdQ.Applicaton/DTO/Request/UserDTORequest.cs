using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.DTO.Request
{
    public class UserDTORequest
    {
        public string Role { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }        


    }
}
