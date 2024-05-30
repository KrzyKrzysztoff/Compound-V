using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Dtos
{
    public class AuthDto
    {
        public string? UserId { get; set; } 
        public string? UserName { get; set; }
        public string? Token { get; set; } 
    }
}
