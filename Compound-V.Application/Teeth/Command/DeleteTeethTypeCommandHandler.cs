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
    public class DeleteTeethTypeCommandHandler(ITeethRepository teethRepository)
        : IRequestHandler<DeleteTeethTypeCommand>
    {
        public async Task Handle(DeleteTeethTypeCommand request, CancellationToken cancellationToken)
        {
            var teethType = await teethRepository.GetTeethTypeById(request.TeethTypeId)
                ?? throw new NotFoundException("TeethType", "Guid", "Id");

            await teethRepository.DeleteTeethType(teethType);
        }
    }
}
