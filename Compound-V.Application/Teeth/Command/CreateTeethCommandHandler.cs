using AutoMapper;
using Compound_V.Domain.Exceptions;
using Compound_V.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Compound_V.Application.Teeth.Command
{
    public class CreateTeethCommandHandler(ITeethRepository teethRepository,
        ITeethTypeRepository teethTypeRepository,
        UserManager<Domain.Entities.User> userManager,
        IMapper mapper)
        : IRequestHandler<CreateTeethCommand>
    {
        public async Task Handle(CreateTeethCommand request, CancellationToken cancellationToken)
        {
            var teeth = mapper.Map<Compound_V.Domain.Entities.Teeth>(request.TeethDto);
            
            teeth.ToothType = await teethTypeRepository.GetTeethTypeById(request.TeethDto.ToothTypeId)
                 ?? throw new NotFoundException("ToothType", "guid", "ById"); ;

            teeth.Users = await userManager.FindByIdAsync(request.TeethDto.UsersId)
                 ?? throw new NotFoundException("User", "string", "ById");

            await teethRepository.CreateTeeth(teeth);
        }
    }
}
