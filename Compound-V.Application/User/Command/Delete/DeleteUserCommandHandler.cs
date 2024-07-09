using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.User.Command
{
    public class DeleteUserCommandHandler(UserManager<Domain.Entities.User> userManager) 
        : IRequestHandler<DeleteUserCommand>
    {
        public async Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await userManager.FindByEmailAsync(request.UserEmail!) 
                ?? throw new Exception("user not founded");

            await userManager.DeleteAsync(user);
        }
    }
}
