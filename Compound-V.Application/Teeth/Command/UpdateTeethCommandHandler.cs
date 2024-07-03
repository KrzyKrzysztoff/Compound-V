using AutoMapper;
using Compound_V.Application.Teeth.Dtos;
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
    public class UpdateTeethCommandHandler(ITeethRepository teethRepository,
        IMapper mapper)
        : IRequestHandler<UpdateTeethCommand>
    {
        public async Task Handle(UpdateTeethCommand request, CancellationToken cancellationToken)
        {
            var teeth = await teethRepository.GetTeethById(request.TeethDto.Id)
                ?? throw new NotFoundException("Teeth", "Guid", "ById");

            teeth.ToothType = request.

            await teethRepository.UpdateTeeth(teeth);
        }
    }
}
