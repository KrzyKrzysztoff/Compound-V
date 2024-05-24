using AutoMapper;
using Compound_V.Application.Dtos;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.User.Query
{
    public class GetUserQueryHandler(IMapper mapper,
        UserManager<Domain.Entities.User> userManager)
        : IRequestHandler<GetUserQuery, UserDto>
    {
        public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await userManager
                .FindByIdAsync(request.Id)
                ?? throw new Exception("User not founded.");

            var userDto = mapper.Map<UserDto>(user);

            return userDto;
        }
    }
}
