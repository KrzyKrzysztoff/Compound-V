using Compound_V.Application.Dtos;
using Compound_V.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.User.Command
{
    public class GenerateTokenCommandHandler(ITokenService tokenService) 
        : IRequestHandler<GenerateTokenCommand, AuthDto>
    {
        public async Task<AuthDto> Handle(GenerateTokenCommand request, CancellationToken cancellationToken)
        {
            string token = tokenService.CreateToken(request.UserId, request.Roles);

            var auth = new AuthDto()
            {
                Token = token
            };

            return auth;
        }
    }
}
