using AutoMapper;
using Compound_V.Application.Teeth.Dtos;
using Compound_V.Domain.Exceptions;
using Compound_V.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Teeth.Command.Update
{
    public class UpdateTeethCommandHandler(ITeethRepository teethRepository,
        ITeethTypeRepository teethTypeRepository,
        UserManager<Domain.Entities.User> userManager,
        IDbRepository dbRepository,
        IMapper mapper)
        : IRequestHandler<UpdateTeethCommand>
    {
        public async Task Handle(UpdateTeethCommand request, CancellationToken cancellationToken)
        {
            var teeth = await teethRepository.GetTeethById(request.TeethDto.Id)
                ?? throw new NotFoundException("Teeth", "Guid", "ById");

            teeth.ToothType = await teethTypeRepository.GetTeethTypeById(request.TeethDto.ToothTypeId)
                ?? throw new NotFoundException("TeethType", "Guid", "ById");

            teeth.Description = request.TeethDto.Description;

            teeth.Users = await userManager.FindByIdAsync(request.TeethDto.UsersId)
                ?? throw new NotFoundException("User", "string", "ById");

            await dbRepository.SaveChanges();
        }
    }
}
