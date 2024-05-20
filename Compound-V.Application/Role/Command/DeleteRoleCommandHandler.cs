using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Role.Command
{
    public class DeleteRoleCommandHandler(RoleManager<IdentityRole> roleManager) 
        : IRequestHandler<DeleteRoleCommand>
    {
        public async Task Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var role = await roleManager.FindByNameAsync(request.Name) ?? throw new Exception("role not founded");

            await roleManager.DeleteAsync(role);
        }
    }
}
