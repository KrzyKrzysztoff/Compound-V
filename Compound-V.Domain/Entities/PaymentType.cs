using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Domain.Entities
{
    public class PaymentType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public DateTime CreateDate { get; set; }
    }
}
