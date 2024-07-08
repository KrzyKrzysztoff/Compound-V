using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.TeethType.Dtos
{
    public class TeethTypeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
