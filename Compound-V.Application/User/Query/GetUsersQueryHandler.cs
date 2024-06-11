using AutoMapper;
using Compound_V.Application.User.Dtos;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.User.Query
{
    public class GetUsersQueryHandler(IMapper mapper,
        UserManager<Domain.Entities.User> userManager) 
        : IRequestHandler<GetUsersQuery, List<UserDto>>
    {
        public async Task<List<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var users = userManager.Users?
                .ToList()
                ?? throw new Exception("Users not founded");

           var usersDto = mapper.Map<List<UserDto>>(users);

            return usersDto;
        }
    }
}
