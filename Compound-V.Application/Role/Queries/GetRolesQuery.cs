using Compound_V.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Role.Queries
{
    public class GetRolesQuery : IRequest<List<RoleDto>>
    {
    }
}
