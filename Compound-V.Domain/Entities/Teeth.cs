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

        public User Users { get; set; } = new User();
        public Teeth ToothType { get; set; } = new Teeth();
    }
}
