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
    public class UpdateTeethTypeCommandHandler(ITeethRepository teethRepository,
        IMapper mapper)
        : IRequestHandler<UpdateTeethTypeCommand>
    {
        public async Task Handle(UpdateTeethTypeCommand request, CancellationToken cancellationToken)
        {
            var teethType = mapper.Map<Domain.Entities.TeethType>(request.TeethTypeDto);

            await teethRepository.UpdateTeethType(teethType);
        }
    }
}
