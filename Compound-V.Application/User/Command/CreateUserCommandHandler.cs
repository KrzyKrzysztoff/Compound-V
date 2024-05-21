using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.User.Command
{
    public class CreateUserCommandHandler(UserManager<Domain.Entities.User> userManager)
        : IRequestHandler<CreateUserCommand>
    {
        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            var user = new Domain.Entities.User
            {
                Email = request.Email,
                NormalizedEmail = request.Email.ToUpper(),
                UserName = request.Name,
                NormalizedUserName = request.Name.ToUpper(),
            };

            // validate in future 

            await userManager.CreateAsync(user, request.Password);
            
        }
    }
}
