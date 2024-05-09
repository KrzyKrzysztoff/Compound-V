using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Domain.Entities
{
    public class Visit
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime VisitDate { get; set; }
        public string? Description { get; set; }

        public User Authors { get; set; } = new User();
        public User Clients { get; set; } = new User();
        public User Dentists { get; set; } = new User();
    }
}
