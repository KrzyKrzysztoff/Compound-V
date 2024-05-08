using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Domain.Entities
{
    public class Log
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string? StackTrace { get; set; }
        public string? Exception{ get; set; }
    }
}
