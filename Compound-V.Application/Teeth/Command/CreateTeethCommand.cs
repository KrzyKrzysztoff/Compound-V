using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Command
{
    public class CreateTeethCommand : IRequest
    {
        public string? Description { get; set; }
        public string UserId { get; set; } = default!;
        public string TeethTypeId { get; set; } = default!;
    }
}
