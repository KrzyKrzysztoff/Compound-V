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
    public class UpdateTeethTypeCommandHandler(ITeethTypeRepository teethTypeRepository,
        IDbRepository dbRepository)
        : IRequestHandler<UpdateTeethTypeCommand>
    {
        public async Task Handle(UpdateTeethTypeCommand request, CancellationToken cancellationToken)
        {
           var teethType = await teethTypeRepository.GetTeethTypeById(request.TeethTypeDto.Id)
                ?? throw new NotFoundException("TeethType", "Guid", "ById"); ;

            teethType.Name = request.TeethTypeDto.Name;

            await dbRepository.SaveChanges();
        }
    }
}
