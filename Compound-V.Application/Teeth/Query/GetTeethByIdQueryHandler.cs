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

namespace Compound_V.Application.Teeth.Query
{
    public class GetTeethByIdQueryHandler(ITeethRepository teethRepository,
        IMapper mapper) 
        : IRequestHandler<GetTeethByIdQuery, TeethDto>
    {
        public async Task<TeethDto> Handle(GetTeethByIdQuery request, CancellationToken cancellationToken)
        {
            var teeth = await teethRepository.GetTeethById(request.TeethId)
                ?? throw new NotFoundException("Teeth", "Guid", "ById");

            var teethDto = mapper.Map<TeethDto>(teeth);

            return teethDto;
        }
    }
}
