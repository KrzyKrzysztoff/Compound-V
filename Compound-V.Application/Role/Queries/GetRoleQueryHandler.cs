using AutoMapper;
using Compound_V.Application.Dtos;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Role.Queries
{
    public class GetRoleQueryHandler(RoleManager<IdentityRole> roleManager,
        IMapper mapper)
        : IRequestHandler<GetRoleQuery, RoleDto>
    {
        public async Task<RoleDto> Handle(GetRoleQuery request, CancellationToken cancellationToken)
        {
            var role = await roleManager.FindByIdAsync(request.Id)
                ?? throw new Exception("role doesn't exist");

            var roleDto = mapper.Map<IdentityRole, RoleDto>(role);

            return roleDto;
        }
    }
}
