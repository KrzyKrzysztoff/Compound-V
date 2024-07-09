using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.User.Command
{
    public class AssignUserRoleCommandHandler(UserManager<Domain.Entities.User> userManager,
        RoleManager<IdentityRole> roleManager)
        : IRequestHandler<AssignUserRoleCommand>
    {
        public async Task Handle(AssignUserRoleCommand request, CancellationToken cancellationToken)
        {
            var user = await userManager.FindByEmailAsync(request.UserEmail)
                ?? throw new Exception("user not founded");

            var role = await roleManager.FindByNameAsync(request.RoleName) 
                ?? throw new Exception("role not founded");

            await userManager.AddToRoleAsync(user, role.Name!);
        }
    }
}
