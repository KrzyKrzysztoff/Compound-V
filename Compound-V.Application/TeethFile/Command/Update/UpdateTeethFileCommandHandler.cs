using AutoMapper;
using Compound_V.Domain.Exceptions;
using Compound_V.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.TeethFile.Command.Update
{
    public class UpdateTeethFileCommandHandler(ITeethFileRepository teethFileRepository,
        IDbRepository dbRepository,
        IMapper mapper)
        : IRequestHandler<UpdateTeethFileCommand>
    {
        public async Task Handle(UpdateTeethFileCommand request, CancellationToken cancellationToken)
        {
            var teethFile = await teethFileRepository.GetTeethFileById(request.TeethFileDto.TeethId)
                ?? throw new NotFoundException("TeethType", "Guid", "Id");

            teethFile.Path = request.TeethFileDto.Path;
            teethFile.Description = request.TeethFileDto.Description;
            
            await dbRepository.SaveChanges();
        }
    }
}
