using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Domain.Entities
{
    public class Toothing
    {
        public Guid Id{ get; set; }
        public string? Description { get; set; }

        public User Users { get; set; } = new User();
        public File? Files { get; set; }
    }
}
