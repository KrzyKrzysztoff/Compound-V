using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public decimal AmountToPay { get; set; }
        public bool IsPayed { get; set; }
        public DateTime CreateDate { get; set; }


        public PaymentType PaymentsType { get; set; } = new PaymentType();
    }
}
