﻿using MediatR;
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
            var user = await userManager.FindByEmailAsync(request.Email);

            if (user != null)
                throw new Exception("user already exist");

            var newUser = new Domain.Entities.User
            {
                Email = request.Email,
                NormalizedEmail = request.Email.ToUpper(),
                UserName = request.Name,
                NormalizedUserName = request.Name.ToUpper(),
            };

            // validate in future, I can add mapper here from Command to User instead of lines upper

            await userManager.CreateAsync(newUser, request.Password);
            
        }
    }
}
