using Compound_V.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Application.User.Command
{
    public class GenerateTokenCommand(UserDto userDto) :IRequest<AuthDto>
    {
        public string UserId { get; set; } = userDto.Id;
        public IEnumerable<string>? Roles { get; set; } = userDto.Roles;
    }
}
