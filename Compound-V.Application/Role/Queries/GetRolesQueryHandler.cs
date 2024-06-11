using AutoMapper;
using Compound_V.Application.Role.Dtos;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Role.Queries
{
    public class GetRolesQueryHandler(RoleManager<IdentityRole> roleManager,
        IMapper mapper)
        : IRequestHandler<GetRolesQuery, List<RoleDto>>
    {
        public async Task<List<RoleDto>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
        {
            var roles = roleManager.Roles?
                .ToList()
                ?? throw new Exception("Roles not founded");

            var rolesDto = mapper.Map<List<RoleDto>>(roles);

            return rolesDto;
        }
    }
}
