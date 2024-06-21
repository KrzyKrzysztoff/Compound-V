using Compound_V.Domain.Exceptions;
using Compound_V.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Command
{
    public class DeleteTeethCommandHandler(ITeethRepository teethRepository) 
        : IRequestHandler<DeleteTeethCommand>
    {
        public async Task Handle(DeleteTeethCommand request, CancellationToken cancellationToken)
        {

            var teeth = await teethRepository.GetTeethById(request.TeethId)
                ?? throw new NotFoundException("Teeth", "Guid", "Id");

            await teethRepository.DeleteTeeth(teeth);
        }
    }
}
