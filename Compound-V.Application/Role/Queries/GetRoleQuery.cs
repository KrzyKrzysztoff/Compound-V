using Compound_V.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Role.Queries
{
    public class GetRoleQuery(string id) : IRequest<RoleDto>
    {
        public string Id { get; } = id;
    }
}
