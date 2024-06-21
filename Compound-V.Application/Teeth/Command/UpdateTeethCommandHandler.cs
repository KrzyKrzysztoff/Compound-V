using Compound_V.Application.Teeth.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Command
{
    public class UpdateTeethCommandHandler : IRequestHandler<UpdateTeethCommand>
    {
        public async Task Handle(UpdateTeethCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
