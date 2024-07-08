using Compound_V.Application.TeethFile.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.TeethFile.Command.Create
{
    public class CreateTeethFileCommand : IRequest
    {
        public TeethFileDto TeethFileDto { get; set; } = default!;
    }
}
