using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Role.Command
{
    public class UpdateRoleCommandHandler(RoleManager<IdentityRole> roleManager)
        : IRequestHandler<UpdateRoleCommand>
    {
        public async Task Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            var role = await roleManager.FindByIdAsync(request.Id) ?? throw new Exception("role not founded");

            if (role.Name == request.Name)
                throw new Exception("New role name is equal the old one");

            await roleManager.UpdateAsync(role);
        }
    }
}
