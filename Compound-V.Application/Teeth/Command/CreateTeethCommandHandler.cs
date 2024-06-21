using AutoMapper;
using Compound_V.Domain.Interfaces;
using MediatR;

namespace Compound_V.Application.Teeth.Command
{
    public class CreateTeethCommandHandler(ITeethRepository teethRepository,
        IMapper mapper)
        : IRequestHandler<CreateTeethCommand>
    {
        public async Task Handle(CreateTeethCommand request, CancellationToken cancellationToken)
        {
            var teeth = mapper.Map<Compound_V.Domain.Entities.Teeth>(request.TeethDto);
            await teethRepository.CreateTeeth(teeth);
        }
    }
}
