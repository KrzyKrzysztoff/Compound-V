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
    public class GetTeethFileByIdQueryHandler(ITeethFileRepository teethFileRepository,
        IMapper mapper)
        : IRequestHandler<GetTeethFileByIdQuery, TeethFileDto>
    {
        public async Task<TeethFileDto> Handle(GetTeethFileByIdQuery request, CancellationToken cancellationToken)
        {
            var teethFile = await teethFileRepository.GetTeethFileById(request.TeethFileId)
             ?? throw new NotFoundException("TeethFile", "Guid", "ById");

            var teethFileDto = mapper.Map<TeethFileDto>(teethFile);

            return teethFileDto;
        }
    }
}
