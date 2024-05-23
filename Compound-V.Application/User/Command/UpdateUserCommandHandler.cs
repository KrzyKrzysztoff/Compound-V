using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.User.Command
{
    public class UpdateUserCommandHandler(UserManager<Domain.Entities.User> userManager)
        : IRequestHandler<UpdateUserCommand>
    {
        public async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await userManager.FindByEmailAsync(request.Email)
                ?? throw new Exception("user doesn't exist");

            user.UserName = request.UserName;
            user.NormalizedUserName = request.UserName.ToUpper();

            await userManager.CreateAsync(user);
        }
    }
}
