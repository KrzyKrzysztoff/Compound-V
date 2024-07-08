using Compound_V.Application.TeethType.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.TeethType.Command.Create
{
    public class CreateTeethTypeCommand : IRequest
    {
        public TeethTypeDto TeethTypeDto { get; set; } = default!;
    }
}
