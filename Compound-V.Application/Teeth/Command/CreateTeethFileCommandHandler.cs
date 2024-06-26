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
    public class CreateTeethFileCommandHandler(ITeethFileRepository teethFileRepository,
        IMapper mapper)
        : IRequestHandler<CreateTeethFileCommand>
    {
        public async Task Handle(CreateTeethFileCommand request, CancellationToken cancellationToken)
        {
            var teethFile = mapper.Map<Domain.Entities.File>(request.TeethFileDto);
            await teethFileRepository.CreateTeethFile(teethFile);
        }
    }
}
