using AutoMapper;
using Compound_V.Application.Teeth.Command;
using Compound_V.Application.Teeth.Dtos;
using Compound_V.Domain.Exceptions;
using Compound_V.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Query
{
    public class GetTeethTypeByIdQueryHandler(ITeethTypeRepository teethTypeRepository,
        IMapper mapper)
        : IRequestHandler<GetTeethTypeByIdQuery, TeethTypeDto>
    {
        public async Task<TeethTypeDto> Handle(GetTeethTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var teethType = await teethTypeRepository.GetTeethTypeById(request.TeethTypeId)
             ?? throw new NotFoundException("TeethType", "Guid", "ById");

            var teethTypeDto = mapper.Map<TeethTypeDto>(teethType);

            return teethTypeDto;
        }
    }
}
