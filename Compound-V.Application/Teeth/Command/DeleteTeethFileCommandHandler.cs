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
    public class DeleteTeethFileCommandHandler(ITeethFileRepository teethFileRepository)
        : IRequestHandler<DeleteTeethFileCommand>
    {
        public async Task Handle(DeleteTeethFileCommand request, CancellationToken cancellationToken)
        {
            var teethFile = await teethFileRepository.GetTeethFileById(request.TeethFileId)
                ?? throw new NotFoundException("TeethFile", "Guid", "Id");

            await teethFileRepository.DeleteTeethFile(teethFile);
        }
    }
}
