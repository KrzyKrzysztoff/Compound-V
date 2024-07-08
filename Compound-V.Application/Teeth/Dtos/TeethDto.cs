using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Dtos
{
    public class TeethDto
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public string UsersId { get; set; } = default!;
        public Guid ToothTypeId { get; set; }
    }
}
