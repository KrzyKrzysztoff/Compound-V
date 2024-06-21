using Compound_V.Application.Teeth.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Command
{
    public class UpdateTeethCommand : IRequest
    {
        public TeethDto TeethDto { get; set; } = default!;
    }
}
