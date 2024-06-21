using AutoMapper;
using Compound_V.Application.Teeth.Dtos;
using Compound_V.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Command
{
    public class UpdateTeethCommandHandler(ITeethRepository teethRepository,
        IMapper mapper)
        : IRequestHandler<UpdateTeethCommand>
    {
        public async Task Handle(UpdateTeethCommand request, CancellationToken cancellationToken)
        {
            var teeth = mapper.Map<Domain.Entities.Teeth>(request.TeethDto);

            await teethRepository.UpdateTeeth(teeth);
        }
    }
}
