using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Dtos
{
    public class TeethFileDto
    {
        public string? Description { get; set; }
        public string Path { get; set; } = default!;
        public Guid TeethId { get; set; }
    }
}
