using Compound_V.Domain.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.Role.Command
{
    public class CreateRoleUserHandler(RoleManager<IdentityRole> roleManager) 
        : IRequestHandler<CreateRoleCommand>
    {
        public async Task Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var role = await roleManager.FindByNameAsync(request.Name);

            if (role != null)
            {
                throw new ResourceAlreadyExistsException("Role", nameof(roleManager.FindByNameAsync), request.Name);
            }

            IdentityRole identityRole = new()
            {
                Name = request.Name,
                NormalizedName = request.Name.ToUpper()
            };

            await roleManager.CreateAsync(identityRole);
        }
    }
}
