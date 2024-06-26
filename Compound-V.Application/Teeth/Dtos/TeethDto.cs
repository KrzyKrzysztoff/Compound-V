using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Dtos
{
    public class TeethDto
    {
        public string? Description { get; set; } 
        public Guid UsersId { get; set; }
        public Guid ToothTypeId { get; set; }
    }
}
