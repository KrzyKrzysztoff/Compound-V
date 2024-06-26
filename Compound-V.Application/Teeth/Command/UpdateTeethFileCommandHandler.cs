using AutoMapper;
using Compound_V.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Command
{
    public class UpdateTeethFileCommandHandler(ITeethFileRepository teethFileRepository,
        IMapper mapper)
        : IRequestHandler<UpdateTeethFileCommand>
    {
        public async Task Handle(UpdateTeethFileCommand request, CancellationToken cancellationToken)
        {
            var teethFile = mapper.Map<Domain.Entities.File>(request.TeethFileDto);

            await teethFileRepository.UpdateTeethFile(teethFile);
        }
    }
}
