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
    public class VerifyUserCredentialsQueryHandler(UserManager<Domain.Entities.User> userManager,
        IMapper mapper)
        : IRequestHandler<VerifyUserCredentialsQuery, UserDto>
    {
        public async Task<UserDto> Handle(VerifyUserCredentialsQuery request, CancellationToken cancellationToken)
        {
            var user = await userManager
                .FindByEmailAsync(request.Email)
                ?? throw new Exception("User not founded");

            var isPasswordCorrect  = await userManager
                   .CheckPasswordAsync(user, request.Password);

            if (!isPasswordCorrect)
                throw new Exception("Password isn't correct");

            var userDto = mapper.Map<UserDto>(user);

            return userDto;
        }
    }
}
