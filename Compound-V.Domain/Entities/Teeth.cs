using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Domain.Entities
{
    public class Teeth
    {
        public Guid Id{ get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }

        public User Users { get; set; } = default!;
        public TeethType ToothType { get; set; } = default!;
    }
}
