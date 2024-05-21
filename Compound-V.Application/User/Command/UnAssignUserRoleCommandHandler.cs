using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.User.Command
{
    public class UnAssignUserRoleCommandHandler (UserManager<Domain.Entities.User> userManager,
        RoleManager<IdentityRole> roleManager)
        : IRequestHandler<UnAssignUserRoleCommand>
    {
        public async Task Handle(UnAssignUserRoleCommand request, CancellationToken cancellationToken)
        {
            var user = await userManager.FindByEmailAsync(request.UserEmail) ?? throw new Exception("user not founded");

            var role = await roleManager.FindByNameAsync(request.RoleName) ?? throw new Exception("role not founded");

            bool isInRole = await userManager.IsInRoleAsync(user, role.Name!);

            if (!isInRole)
                 throw new Exception("user is not in role");

            await userManager.RemoveFromRoleAsync(user, role.Name!);
        }
    }
}
