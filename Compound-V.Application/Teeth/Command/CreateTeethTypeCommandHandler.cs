using AutoMapper;
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
    public class CreateTeethTypeCommandHandler(ITeethTypeRepository teethTypeRepository,
        IMapper mapper)
        : IRequestHandler<CreateTeethTypeCommand>
    {
        public async Task Handle(CreateTeethTypeCommand request, CancellationToken cancellationToken)
        {
            var teethType = mapper.Map<Domain.Entities.TeethType>(request.TeethTypeDto);
            await teethTypeRepository.CreateTeethType(teethType);
        }
    }
}
